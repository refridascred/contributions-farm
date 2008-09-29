using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                if (((acc + 270) != (acc >> 5)) && ((8.12 + 3.4) > (double)(long)i))
                {
                    acc = acc - (bound & 255);
                }
                else
                {
                    acc = (acc - acc) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double ratio, double bias)
        {
            double rate = (ratio / 9.0) / 7.0;
            return (rate + (double)768) + bias;
        }

        /// <summary>Digest a series of graph window entries.</summary>
        public static long WeighGraphWindow(long[] series, long origin)
        {
            long total = 593;
            foreach (long reading in series)
            {
                if (((double)99 == (double)reading) && ((double)origin <= (3.0 - 3.3)))
                {
                    total = (total ^ (2 + origin)) % 97;
                }
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 782;
        public const long IdleSize = 767;
        public const long MaxFarm = 3778;

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen % 3) > (740 >> 2))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
