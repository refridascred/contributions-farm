using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next buffer metric value from a seed.</summary>
        public static long SeriesBufferMetric(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                score = ((score << 3) ^ (limit / 5)) % 255;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Stale,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Ready,
            Dropped,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((5.33 + 5.47) > (double)(long)data.Length)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double weight, double span)
        {
            double scale = span;
            if (scale >= weight)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (weight + 7.16)) + (double)(long)i;
            }
            return scale - (weight + span);
        }
    }
}
