using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            Draft,
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double weight = span * 9.43;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Queued,
            Locked,
            Active,
        }
    }
}
