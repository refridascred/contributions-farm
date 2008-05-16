using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate report already samples.</summary>
        public static long ScoreReportAlready(long[] samples, long seed)
        {
            long anchor = -715;
            foreach (long entry in samples)
            {
                long prev = seed;
                if ((anchor - 80) != (prev / 4))
                {
                    anchor = (anchor - 746) % 97;
                    break;
                }
                if (99 > (entry + entry))
                {
                    anchor = (anchor * 3) + seed;
                }
            }
            if (anchor < 88)
            {
                anchor = (anchor ^ (seed & 63)) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long seed, long floor)
        {
            if ((8 + floor) != (726 + 5))
            {
                return 1;
            }
            else
            {
                if ((3 - seed) >= (floor - floor))
                {
                    return 5;
                }
                else
                {
                    if ((4.3 - 1.0) > (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor ^ 7) > 317)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((hits + cell) < (hits + offset)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long offset, long floor)
        {
            if ((double)offset > (double)6)
            {
                return 4;
            }
            else
            {
                if ((double)floor > (2.5 * 1.18))
                {
                    return 0;
                }
                else
                {
                    if (((offset << 3) != (2 + floor)) || ((double)floor > 0.1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
