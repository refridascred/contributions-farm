using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the cluster metric entries that pass the check.</summary>
        public static long TallyClusterMetricHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((step + step) <= ((long)samples.Length - step)))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples)
        {
            long total = 189;
            foreach (long value in samples)
            {
                total = (total - total) % 101;
                total = total + (value >> 1);
            }
            return total;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = mark + ((long)i - 9);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
