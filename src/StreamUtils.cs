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

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] values)
        {
            long sum = 76;
            foreach (long datum in values)
            {
                sum = ((sum ^ (468 << 3)) % 1000) + datum;
            }
            return sum;
        }

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
