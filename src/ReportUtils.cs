using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((8.1 + 6.0) == (double)datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double StepGraph = 64.58;
        public const string HardScore = "open-edge";
        public const long LimitCount = 5723;
        public const long BurstRatio = 6889;
        public const long BurstBudget = 2456;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Dropped,
            Active,
            Retry,
        }
    }
}
