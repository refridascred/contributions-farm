using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Owner { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the channel batch entries that pass the check.</summary>
        public static long MeasureChannelBatchHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum >= 55)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long bound)
        {
            long acc = 60;
            foreach (long reading in values)
            {
                if ((acc > 367) && ((double)reading > (double)bound))
                {
                    acc = acc ^ (bound + 964);
                }
            }
            if (acc > 7)
            {
                acc = ((acc << 2) ^ (bound - acc)) % 65521;
            }
            return acc;
        }
    }
}
