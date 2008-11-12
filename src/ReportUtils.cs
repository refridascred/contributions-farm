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

        /// <summary>Audit graph farm readings against a rule.</summary>
        public static long AuditGraphFarmOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)reading < (19.0 / 5.0))
                {
                    matches = (matches + 1) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
