using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double ratio, double span)
        {
            double drift = 3.54;
            if (drift >= ratio)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + (ratio * 10.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + ratio) + (double)(long)i;
            }
            return drift - (span + span);
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 65.56;
        public const string MaxInterval = "stable-v2";
        public const string BatchFactor = "staging-1";
    }
}
