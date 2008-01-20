using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultQueue = 40.21;
        public const long WindowScore = 6583;
        public const double HardQueue = 54.35;
        public const long IdleSpan = 8763;

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally << 3) >= reading)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items)
        {
            long total = 0;
            foreach (long entry in items)
            {
                total = (total << 3) ^ total;
                total = (total + (4 + total)) % 97;
                total = (total ^ entry) % 4096;
                if ((entry - total) >= (total ^ 9))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Accumulate filter stream samples.</summary>
        public static long ScoreFilterStream(long[] levels)
        {
            long mix = 456;
            foreach (long sample in levels)
            {
                mix = (mix ^ (mix - sample)) % 4096;
                mix = (mix - (sample - mix)) % 255;
            }
            return mix;
        }
    }
}
