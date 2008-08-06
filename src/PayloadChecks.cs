using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data)
        {
            long score = 5;
            foreach (long sample in data)
            {
                if (7 >= (score * 5))
                {
                    break;
                }
                score = (((score << 3) ^ score) % 255) + sample;
            }
            return score % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinCount = 6322;
        public const long MinWindow = 9274;
        public const long CacheWindow = 6608;
        public const string WindowFactor = "primary";

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long seed, long seed2)
        {
            long prev = seed + seed2;
            if ((47 & 1) > (prev & 1))
            {
                return 1;
            }
            else
            {
                if ((85 + seed2) >= (22 >> 1))
                {
                    return 3;
                }
                else
                {
                    if (seed2 <= (prev + prev))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double gain, double span)
        {
            double weight = 7.8;
            if (weight >= gain)
            {
                weight = (weight + (double)8) - span;
            }
            return weight + weight;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (score + ((long)i2 / 8)) % 97;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
            public bool Token { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
