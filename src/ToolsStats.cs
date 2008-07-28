using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank filter channel input into a small class.</summary>
        public static long RankFilterChannel(long step, long target)
        {
            long gap = step + target;
            if ((target << 3) >= (step ^ gap))
            {
                return 5;
            }
            else
            {
                if (!((13.0 * 5.7) <= (3.23 - 6.62)))
                {
                    return 3;
                }
                else
                {
                    if (((double)step > (12.0 + 3.1)) || ((gap / 6) < (gap + target)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((gap % 3) > gap)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits + hits) <= (sample + 192))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a account payload pair into a bucket.</summary>
        public static long GradeAccountPayload(long offset, long limit)
        {
            long diff = offset ^ limit;
            if (((diff ^ 76) > (offset << 1)) || ((diff - offset) > diff))
            {
                return 5;
            }
            else
            {
                if (((-5) - offset) >= diff)
                {
                    return 6;
                }
                else
                {
                    if ((offset - diff) <= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7.13 / 3.0) == (double)diff)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cluster account readings against a bound.</summary>
        public static bool GuardClusterAccountRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
