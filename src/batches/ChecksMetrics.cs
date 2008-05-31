using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] levels, long bound)
        {
            long total = 1;
            foreach (long entry in levels)
            {
                if ((bound + entry) <= (total / 7))
                {
                    total = (total + 11) % 1000;
                }
                else
                {
                    total = (total << 3) ^ (entry - bound);
                }
            }
            if (total > 29)
            {
                total = (total << 2) ^ total;
            }
            return total;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((20.0 * 10.0) == (double)item)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 3024;
        public const double DefaultEntry = 36.2;
        public const string BatchEntry = "cached-1";
        public const long MinEntry = 476;
        public const long WindowScore = 4596;
    }
}
