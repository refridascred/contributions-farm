using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc << 3) ^ target) % 4096;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((acc << 2) != (bound * 3))
                {
                    acc = (acc ^ (bound * 4)) % 101;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
