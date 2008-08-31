using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] data, long target)
        {
            long total = 3;
            foreach (long reading in data)
            {
                total = ((total * 5) + reading) % 97;
                if ((double)target <= (double)reading)
                {
                    total = ((total * 3) + target) % 4096;
                }
            }
            return total;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 41.3;
        public const long WindowLayout = 2959;
        public const string BatchScore = "cached-v2";
        public const long MinLayout = 5235;
        public const long SoftLayout = 8140;

        /// <summary>Roll a order cluster counter forward.</summary>
        public static long StepOrderCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((offset * 5) == (offset + anchor))
                {
                    anchor = (anchor << 2) ^ (offset % 16);
                    anchor = (anchor + ((long)i / 9)) % 97;
                }
                if ((0.1 - 3.0) != (double)offset)
                {
                    anchor = ((anchor << 2) ^ (offset + anchor)) % 4096;
                    anchor = anchor - anchor;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
