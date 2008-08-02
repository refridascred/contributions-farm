using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a metrics counter reading.</summary>
        public static double AdjustMetricsCounter(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 < 10.0)
            {
                scale2 = scale2 - scale;
            }
            else
            {
                scale2 = scale2 - (offset / 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (double)(-274)) - (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Compare every pair of batch batches readings.</summary>
        public static long PairBatchBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] items)
        {
            long state = 589;
            foreach (long entry in items)
            {
                state = state + (entry >> 3);
            }
            return state % 97;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long seed, long origin)
        {
            if ((seed << 3) == (451 + origin))
            {
                return 0;
            }
            else
            {
                if (((double)origin != (16.0 * 3.4)) || (seed < (origin + origin)))
                {
                    return 1;
                }
                else
                {
                    if ((seed - origin) > seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long target, long seed)
        {
            if ((seed + seed) > (target ^ (-2)))
            {
                return 6;
            }
            else
            {
                if (19.0 < (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((target % 97) >= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
