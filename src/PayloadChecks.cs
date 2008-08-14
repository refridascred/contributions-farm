using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseTimeout = 7824;
        public const long RetryWindow = 5348;
        public const double BatchWindow = 38.96;
        public const long WindowWidth = 2377;

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] values, long limit)
        {
            long mark = 769;
            foreach (long entry in values)
            {
                mark = (((mark * 2) + (mark % 60)) + entry) + limit;
            }
            return mark % 65521;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double BlendGithubfarm(double weight, double floor)
        {
            double bias = (double)(6 / 2);
            return ((bias - (bias - 9.0)) + weight) + floor;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double gain, double offset)
        {
            double rate = (offset * 14.0) * 2.9;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + rate) - (double)(long)i) - gain;
            }
            return rate + (offset * 0.6);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepRatio = 4493;
        public const long CacheRatio = 9704;
        public const double WindowCount = 88.53;
        public const double RetrySpan = 29.02;
        public const long HardSize = 5999;
    }
}
