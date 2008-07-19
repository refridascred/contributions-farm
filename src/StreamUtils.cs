using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long limit, long floor)
        {
            if ((floor & 63) <= floor)
            {
                return 2;
            }
            else
            {
                if (limit < (limit & 3))
                {
                    return 8;
                }
                else
                {
                    if (!((10.0 - 2.67) > (double)floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + floor) >= limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen <= (item * 4))
                {
                    seen = (seen + 2) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long origin, long seed)
        {
            long edge = origin ^ seed;
            if ((double)seed < (8.4 + 8.0))
            {
                return 3;
            }
            else
            {
                if (!((origin + seed) < (edge & 127)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] data, long bound)
        {
            long result = 59;
            foreach (long sample in data)
            {
                result = (result - (sample % 24)) - bound;
            }
            return result;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
