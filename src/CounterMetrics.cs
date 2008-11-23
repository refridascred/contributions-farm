using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the schema record series from a seed.</summary>
        public static long SeriesSchemaRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = (score + (offset - offset)) % 4096;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit report batch readings against a rule.</summary>
        public static long CountReportBatchMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count < 186)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= (double)646)
            {
                weight2 = (weight2 + weight2) - offset;
            }
            return weight2 + weight;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Ready,
            Retry,
            Paused,
        }
    }
}
