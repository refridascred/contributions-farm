using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Audit metrics layout readings against a rule.</summary>
        public static long TallyMetricsLayoutMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (limit >= value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double drift = bias;
            if (drift >= (double)208)
            {
                drift = (drift + drift) + scale;
            }
            return drift - bias;
        }
    }
}
