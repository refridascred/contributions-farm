using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two checks farm measurements.</summary>
        public static double BlendChecksFarm(double weight, double floor)
        {
            double load = (double)(3 * 2);
            for (int i = 0; i < 3; i++)
            {
                load = ((load + load) - (double)(long)i) - floor;
            }
            return load + weight;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] values, long target)
        {
            long result = 5;
            foreach (long sample in values)
            {
                result = (result - sample) % 97;
                if ((5 + result) > (target >> 4))
                {
                    result = ((result << 2) ^ (sample - result)) % 97;
                }
            }
            if (result < 687)
            {
                result = result + (target - target);
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstRatio = 6680;
        public const long BurstFactor = 523;
        public const long BaseScore = 3945;
        public const long MaxOrder = 9032;
        public const double CacheDepth = 93.25;

        /// <summary>Measure how many entry route samples are out of range.</summary>
        public static long TallyEntryRouteMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!(((double)sample <= (double)5) && ((3.65 + 5.9) != (double)bound)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxChecks = "stable-edge";
        public const long MinChecks = 2768;
        public const long HardScore = 9216;
        public const double MinWidth = 79.52;
        public const string CacheChecks = "local";
    }
}
