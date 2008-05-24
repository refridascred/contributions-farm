using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix * 5) + mix;
                if (offset >= (896 << 2))
                {
                    break;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry >= (entry + matches)) && ((entry % 12) >= matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
