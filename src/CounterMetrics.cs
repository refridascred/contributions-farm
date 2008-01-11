using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a cache context reading by value.</summary>
        public static long LookupCacheContextIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Failed,
            Done,
            Ready,
            New,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] data)
        {
            long mix = 0;
            foreach (long value in data)
            {
                if (!((value - mix) == (14 >> 4)))
                {
                    mix = (mix ^ (mix + value)) % 4096;
                }
                else
                {
                    mix = (mix << 2) ^ mix;
                }
            }
            return mix % 4096;
        }
    }
}
