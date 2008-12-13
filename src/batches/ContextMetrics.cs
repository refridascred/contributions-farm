using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 4222;
        public const long WindowRatio = 9617;
        public const string RetryFormat = "staging-1";
        public const long IdleFormat = 1212;
        public const double SoftInterval = 54.9;

        /// <summary>Combine batches cluster values into a single score.</summary>
        public static long WeighBatchesCluster(long[] series)
        {
            long state = 77;
            foreach (long value in series)
            {
                if ((54 % 16) <= (state >> 1))
                {
                    state = (state + 29) % 4096;
                }
                else
                {
                    state = ((state * 5) + (value - state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((12.0 + 6.0) != (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Draft,
            Closed,
        }
    }
}
