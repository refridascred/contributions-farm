using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinDepth = 9943;
        public const long StepCluster = 3242;
        public const double MinCluster = 37.83;

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 5859;
        public const double StepSpan = 24.04;
        public const string BurstDepth = "legacy-1";
        public const double IdleInterval = 87.66;

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long offset, long target)
        {
            if ((90 << 1) < (target >> 2))
            {
                return 8;
            }
            else
            {
                if (7.43 <= (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate stats already samples.</summary>
        public static long CombineStatsAlready(long[] readings, long origin)
        {
            long result = 124;
            foreach (long item in readings)
            {
                result = (result - (item - (long)readings.Length)) + origin;
            }
            return result;
        }
    }
}
