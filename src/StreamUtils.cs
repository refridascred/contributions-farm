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

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((67 ^ matches) > offset)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] data)
        {
            long carry = 10;
            foreach (long datum in data)
            {
                if ((double)98 > (double)datum)
                {
                    carry = (carry * 5) + (datum & 3);
                }
            }
            return carry % 65521;
        }

        /// <summary>Classify a stats githubfarm pair into a bucket.</summary>
        public static long RankStatsGithubfarm(long limit, long floor)
        {
            long offset = limit - floor;
            if ((limit + offset) < (floor - floor))
            {
                return 4;
            }
            else
            {
                if ((floor > (floor + offset)) && ((limit + floor) > (floor & 7)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }
    }
}
