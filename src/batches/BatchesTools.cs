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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((24 << 2) <= (reading % 7))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }
    }
}
