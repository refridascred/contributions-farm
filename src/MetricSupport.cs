using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample ^ limit) == (limit % 16))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Mode { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next channel batch value from a seed.</summary>
        public static long StepChannelBatch(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
