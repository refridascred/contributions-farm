using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitWidth = "staging";
        public const long RetryCounter = 6730;
        public const string BatchBudget = "standard-edge";
        public const long LimitCounter = 4057;

        /// <summary>Blend two metric order measurements.</summary>
        public static double BlendMetricOrder(double bias, double span)
        {
            double scale = (span - 20.0) - 3.0;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + span) + (double)(long)i) + bias;
            }
            return scale + span;
        }
    }
}
