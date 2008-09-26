using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double rate, double offset)
        {
            double ratio = (rate - 3.0) + (rate + offset);
            if (ratio <= ratio)
            {
                ratio = ratio - (offset - rate);
            }
            return ratio - 15.0;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "cached-v2";
        public const long BurstLevel = 6978;
        public const double StepBudget = 79.44;
        public const long BatchLevel = 1672;
        public const long MaxEntry = 1146;

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Synced,
            Ready,
            Active,
            Draft,
        }
    }
}
