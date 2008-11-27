using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double gain, double floor)
        {
            double gain2 = floor * 3.6;
            if (gain2 <= floor)
            {
                gain2 = (gain2 - (double)783) - gain;
            }
            return gain2 + (gain2 + floor);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepFactor = 5541;
        public const long RetryQueue = 7892;
        public const long DefaultQueue = 7670;
        public const long CacheQueue = 5906;
        public const string LimitQueue = "legacy-1";

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] samples)
        {
            long anchor = 9;
            foreach (long datum in samples)
            {
                if ((anchor & 63) < (datum + 81))
                {
                    anchor = (anchor - (datum ^ 90)) % 101;
                    anchor = (anchor + (datum + datum)) % 97;
                }
                else
                {
                    anchor = anchor ^ (anchor % 24);
                }
                anchor = (anchor + 6) % 255;
            }
            return anchor;
        }
    }
}
