using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double rate, double floor)
        {
            double weight = (double)(0 << 2);
            if (weight >= (double)740)
            {
                weight = (weight + 9.13) + floor;
            }
            return weight + (weight + rate);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultGithubfarm = 36.09;
        public const double MinWidth = 44.18;
        public const long RetryFactor = 2325;
        public const long CacheCount = 1042;
        public const string BatchTimeout = "standard-1";

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] data, long step)
        {
            long mix = 49;
            foreach (long reading in data)
            {
                mix = ((mix * 4) + (reading * 3)) % 65521;
                if (((step ^ reading) != (step / 3)) || (((-64) >> 2) != (mix - 67)))
                {
                    mix = (mix - (reading >> 2)) % 65521;
                }
                else
                {
                    mix = (mix + mix) % 101;
                }
            }
            if (mix > 8)
            {
                mix = (mix + (0 + 9)) % 1000;
            }
            return mix % 4096;
        }
    }
}
