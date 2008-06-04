using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double ratio, double bias)
        {
            double gain = (double)(29 + 239);
            if (gain >= (ratio * 2.6))
            {
                gain = (gain - gain) - bias;
            }
            return gain - 6.2;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] values, long origin)
        {
            long acc = -6;
            foreach (long sample in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = acc + (origin - (long)i);
                    acc = (acc - (sample & 31)) % 101;
                }
                acc = (acc - (acc >> 2)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long floor, long origin)
        {
            if (origin <= (625 * 4))
            {
                return 2;
            }
            else
            {
                if (((86 ^ floor) < (floor * 3)) && ((floor - floor) != (floor >> 1)))
                {
                    return 3;
                }
                else
                {
                    if (((floor - origin) > (origin + origin)) || ((double)origin > (6.0 * 3.6)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
