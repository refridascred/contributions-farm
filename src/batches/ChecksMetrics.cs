using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((-94) >> 4) >= (sample - tally))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum / 3) < (datum % 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long limit, long offset)
        {
            long diff = limit ^ offset;
            if (5.0 <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((diff > limit) && ((double)limit < 6.0))
                {
                    return 0;
                }
                else
                {
                    if (!((limit - limit) > (offset % 24)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset + limit) <= (limit >> 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] readings, long seed)
        {
            long anchor = 3;
            foreach (long entry in readings)
            {
                if ((double)anchor >= (double)seed)
                {
                    anchor = (anchor << 3) ^ (entry + entry);
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor % 60)) % 1000;
                }
            }
            if (anchor > 15)
            {
                anchor = (anchor - (seed ^ seed)) % 4096;
            }
            return anchor;
        }

        /// <summary>Check that every entry command entry stays within the limit.</summary>
        public static bool ValidateEntryCommandRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 3975;
        public const string CacheEntry = "local-edge";
        public const double RetryWidth = 0.61;
    }
}
