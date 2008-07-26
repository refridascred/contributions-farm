using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double bias, double span)
        {
            double ratio = (double)12 + (double)354;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + span;
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long step, long origin)
        {
            long slot = step + origin;
            if (4.0 > (double)origin)
            {
                return 8;
            }
            else
            {
                if (((step & 31) < (452 + step)) && (slot < (6 & 255)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a commits payload value against two limits.</summary>
        public static long SortCommitsPayload(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((offset & 63) != (651 + delta))
            {
                return 5;
            }
            else
            {
                if ((offset > (29 - delta)) || ((623 & 1) > (delta - offset)))
                {
                    return 3;
                }
                else
                {
                    if ((4.0 - 3.5) < (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i + mix) <= 233)
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] levels, long target)
        {
            long score = 51;
            foreach (long item in levels)
            {
                score = (((score * 2) + item) % 255) - target;
                score = score - (item ^ item);
            }
            return score % 4096;
        }
    }
}
