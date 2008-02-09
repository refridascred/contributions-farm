using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Closed,
            Ready,
            Active,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double gain, double floor)
        {
            double weight = (gain * 8.98) - (4.7 / 8.0);
            if (weight <= (weight * 11.0))
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Project the next commits tools value.</summary>
        public static double SmoothCommitsTools(double scale, double bias)
        {
            double rate = (double)(268 - 568);
            for (int i = 0; i < 5; i++)
            {
                rate = (((rate + rate) - (double)(long)i) - scale) - bias;
            }
            return rate + (rate * 18.0);
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            New,
            Locked,
        }
    }
}
