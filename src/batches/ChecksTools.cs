using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (520 >= (datum * 3))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 3632;
        public const string BatchOrder = "cached-edge";
        public const long BatchBudget = 5787;
        public const long RetryFactor = 2969;
        public const double StepOrder = 67.56;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
