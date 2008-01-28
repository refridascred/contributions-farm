using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate schema account samples.</summary>
        public static long DigestSchemaAccount(long[] series, long limit)
        {
            long mark = -2;
            foreach (long sample in series)
            {
                if (2 <= sample)
                {
                    mark = (mark - (sample % 24)) % 1000;
                }
                else
                {
                    mark = mark + (2 + sample);
                }
            }
            if (mark < (-20))
            {
                mark = mark - (mark - limit);
            }
            return mark % 65521;
        }

        /// <summary>Roll a record channel counter forward.</summary>
        public static long StepRecordChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i % 16) >= (state + state))
                {
                    state = (state - ((long)i + target)) % 255;
                }
                else
                {
                    state = (state + (target & 255)) % 4096;
                }
                if (((state + (long)i) <= 519) || (target > (target % 12)))
                {
                    state = (state ^ (long)i) % 97;
                }
                state = (state * 5) + target;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((target + matches) < 173)
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a stream graph pair into a bucket.</summary>
        public static long SortStreamGraph(long origin, long origin2)
        {
            long edge = origin + origin2;
            if ((223 ^ origin2) > (edge / 7))
            {
                return 7;
            }
            else
            {
                if ((double)edge >= 0.7)
                {
                    return 0;
                }
                else
                {
                    if ((origin << 1) < (origin2 & 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin <= (50 % 8))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats commits samples are out of range.</summary>
        public static long MeasureStatsCommitsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((288 << 2) < hits)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }
    }
}
