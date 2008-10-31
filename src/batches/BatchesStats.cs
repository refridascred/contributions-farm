using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double offset)
        {
            double weight = (double)87;
            if (weight < weight)
            {
                weight = (weight - (weight - ratio)) - offset;
            }
            else
            {
                weight = weight - ratio;
            }
            return weight - (7.2 / 6.0);
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count % 100) == (sample ^ sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Stamp { get; set; }
            public long Count { get; set; }
        }
    }
}
