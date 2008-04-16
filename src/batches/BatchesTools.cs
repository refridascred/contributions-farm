using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] items)
        {
            long mix = 4;
            foreach (long reading in items)
            {
                mix = (((mix << 3) ^ (mix / 3)) % 4096) + reading;
            }
            return mix % 4096;
        }
    }
}
