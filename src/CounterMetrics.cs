using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit support stream readings against a rule.</summary>
        public static long CountSupportStreamGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen < (20 * 2))
                {
                    seen = ((seen + 3) - cell) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double gain = span;
            return gain + weight;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Stale,
            Dropped,
            Done,
        }
    }
}
