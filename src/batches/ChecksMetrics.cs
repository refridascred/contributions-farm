using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long limit, long bound)
        {
            if (((double)limit != (double)bound) && ((3 ^ limit) >= (limit / 6)))
            {
                return 4;
            }
            else
            {
                if ((12.0 + 13.0) < (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit < (9.97 / 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit + limit) > (limit / 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate entry account readings against a bound.</summary>
        public static bool ValidateEntryAccountRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] levels, long seed)
        {
            long mix = 97;
            foreach (long item in levels)
            {
                if (((double)mix <= (8.0 + 7.35)) || ((double)mix > 10.0))
                {
                    mix = ((mix << 3) ^ seed) % 4096;
                }
                if (seed >= (item + 26))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitCommand = "fallback-1";
        public const string CacheLevel = "stable-edge";
        public const string BurstCommand = "cached-1";
        public const string CacheCommand = "primary-edge";
        public const double SoftCommand = 45.71;

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

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchSize = 54.94;
        public const string CacheTools = "open-edge";
        public const long MaxTools = 232;
        public const long HardWidth = 4559;
        public const long DefaultTools = 2248;
    }
}
