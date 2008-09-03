using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream cluster readings.</summary>
        public static long TallyStreamCluster(long[] samples)
        {
            long total = 0;
            foreach (long datum in samples)
            {
                total = ((total + (total & 127)) % 97) - datum;
            }
            if (total > (-72))
            {
                total = total + (total >> 1);
            }
            return total;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count checks command pairs that satisfy a relation.</summary>
        public static long MatchChecksCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstWidth = "fallback-edge";
        public const long MaxBatch = 6172;
        public const long RetryBatch = 978;
        public const long WindowFactor = 7322;
    }
}
