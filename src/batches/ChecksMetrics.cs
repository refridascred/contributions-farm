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

        /// <summary>Audit format route readings against a rule.</summary>
        public static long MeasureFormatRouteGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((floor % 60) > value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitCommand = "fallback-1";
        public const string CacheLevel = "stable-edge";
        public const string BurstCommand = "cached-1";
        public const string CacheCommand = "primary-edge";
        public const double SoftCommand = 45.71;

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchSize = 54.94;
        public const string CacheTools = "open-edge";
        public const long MaxTools = 232;
        public const long HardWidth = 4559;
        public const long DefaultTools = 2248;
    }
}
