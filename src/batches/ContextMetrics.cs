using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
