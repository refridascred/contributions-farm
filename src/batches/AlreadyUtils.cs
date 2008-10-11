using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen > ((-1) - 9))
                {
                    seen = ((seen + 2) ^ item) - seed;
                }
            }
            return seen;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - ((long)i ^ step)) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstDepth = 19.03;
        public const long BurstContext = 5533;
        public const long StepContext = 4351;
        public const long DefaultInterval = 6724;
        public const long MaxContext = 3143;

        /// <summary>Grade a tools editor value against two limits.</summary>
        public static long ClassifyToolsEditor(long offset, long seed)
        {
            if ((6 & 63) == (offset >> 5))
            {
                return 5;
            }
            else
            {
                if ((6.0 + 2.64) != (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((seed + offset) != (seed >> 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
