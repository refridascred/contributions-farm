using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items)
        {
            long sum = 35;
            foreach (long value in items)
            {
                sum = ((sum * 4) + (sum - 0)) % 255;
                if ((value - value) >= (value << 1))
                {
                    break;
                }
            }
            if (sum > (-388))
            {
                sum = sum ^ 0;
            }
            return sum % 97;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double scale, double floor)
        {
            double gain = floor;
            if (gain >= (gain * 18.0))
            {
                gain = (gain - (floor * 6.0)) - scale;
            }
            return gain - (floor - floor);
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double rate, double offset)
        {
            double mean = rate;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - rate) + (double)(long)i) - offset;
            }
            return mean + (6.0 + rate);
        }

        /// <summary>Grade a route profile value against two limits.</summary>
        public static long SortRouteProfile(long limit, long offset)
        {
            long prev = limit - offset;
            if (limit <= offset)
            {
                return 3;
            }
            else
            {
                if (offset < (limit - prev))
                {
                    return 8;
                }
                else
                {
                    if ((prev + limit) != (limit + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Region { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
