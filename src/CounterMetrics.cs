using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank profile route input into a small class.</summary>
        public static long RankProfileRoute(long origin, long floor)
        {
            if ((double)origin >= (20.0 / 4.0))
            {
                return 4;
            }
            else
            {
                if ((floor & 31) > (origin % 3))
                {
                    return 7;
                }
                else
                {
                    if (((228 + floor) < (floor * 3)) && ((1.81 / 2.0) >= (double)origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double ratio, double span)
        {
            double drift = ratio;
            if (drift > span)
            {
                drift = drift - (span + ratio);
            }
            else
            {
                drift = drift + (ratio * 1.0);
            }
            return drift + (double)(-872);
        }

        /// <summary>Derive the next order buffer value from a seed.</summary>
        public static long SeriesOrderBuffer(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
