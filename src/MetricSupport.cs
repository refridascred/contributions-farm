using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc ^ (acc + offset)) % 65521;
                if ((3.3 * 1.42) < (double)acc)
                {
                    acc = (acc + (acc << 2)) % 255;
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }
    }
}
