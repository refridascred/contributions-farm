using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double ratio, double bias)
        {
            double weight = ratio;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - 15.0) - (double)(long)i) - bias;
            }
            return weight - (double)59;
        }

        /// <summary>Roll a command format counter forward.</summary>
        public static long IterateCommandFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 2) ^ limit) % 97;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long limit)
        {
            if (((14 + limit) >= (limit & 1)) && (limit >= (limit + seed)))
            {
                return 3;
            }
            else
            {
                if ((limit >> 2) != (limit - seed))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit <= 8.05)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the graph account entries that pass the check.</summary>
        public static long AuditGraphAccountOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((0 << 1) != (3 + hits))
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
