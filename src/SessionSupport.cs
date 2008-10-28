using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate cache stream readings against a bound.</summary>
        public static bool ValidateCacheStreamRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double weight, double offset)
        {
            double drift = offset;
            if (drift >= (double)5)
            {
                drift = drift + (double)964;
            }
            else
            {
                drift = drift - (offset * 3.55);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (1.82 + weight);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultGraph = "local-edge";
        public const long CacheFactor = 7477;
        public const string LimitScore = "latest-v2";
        public const long RetryBudget = 280;
    }
}
