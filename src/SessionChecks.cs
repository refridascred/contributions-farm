using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] samples)
        {
            long acc = 983;
            foreach (long value in samples)
            {
                acc = (acc + (1 + 69)) % 255;
                acc = (acc << 3) ^ acc;
                acc = (acc * 5) + acc;
                if (!((acc % 100) != (value >> 3)))
                {
                    break;
                }
            }
            if (acc > 65)
            {
                acc = (acc ^ acc) % 101;
            }
            return acc;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double drift = ratio;
            if (drift >= (ratio + ratio))
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift - floor;
            }
            return drift + (double)213;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long seed, long target)
        {
            if (!((32 - target) >= target))
            {
                return 2;
            }
            else
            {
                if (((-434) & 1) <= seed)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
