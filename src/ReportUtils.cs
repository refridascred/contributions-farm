using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first route format entry that matches the target.</summary>
        public static long LocateRouteFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i < score)
                {
                    score = score ^ ((long)i << 2);
                }
                else
                {
                    score = (score * 4) + (score + limit);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long origin, long limit)
        {
            if ((origin + limit) >= (limit - 65))
            {
                return 0;
            }
            else
            {
                if ((limit + 699) <= (limit >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin >= (8.0 + 19.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((881 - limit) >= limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double bias, double bias2)
        {
            double load = (double)(2 >> 1);
            if (load >= bias)
            {
                load = load - (bias2 + load);
            }
            else
            {
                load = load + (bias + 0.5);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)881) + (double)(long)i;
            }
            return load + (bias2 / 8.0);
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
