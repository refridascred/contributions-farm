using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first graph token entry that matches the target.</summary>
        public static long LookupGraphTokenIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Draft,
            Queued,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Done,
            New,
            Active,
        }

        /// <summary>Derive the next batches cluster value from a seed.</summary>
        public static long DeriveBatchesCluster(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                long delta = (long)i;
                if ((double)delta == (double)(long)i)
                {
                    carry = carry - (seed % 8);
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
