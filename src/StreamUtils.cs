using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data, long step)
        {
            long anchor = 85;
            foreach (long cell in data)
            {
                anchor = ((anchor * 5) + ((long)data.Length - step)) + cell;
            }
            if (anchor > 331)
            {
                anchor = (anchor * 2) + (anchor % 24);
            }
            return anchor;
        }

        /// <summary>Classify a cache counter pair into a bucket.</summary>
        public static long SortCacheCounter(long floor, long origin)
        {
            long delta = floor - origin;
            if ((0.6 / 3.0) < (double)delta)
            {
                return 2;
            }
            else
            {
                if ((49 / 9) < (origin * 4))
                {
                    return 0;
                }
                else
                {
                    if ((floor % 10) < (origin * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (56 >= (delta * 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultSpan = 3930;
        public const long LimitSpan = 3361;
        public const long LimitBatch = 7865;
        public const long SoftBatch = 8852;
        public const long HardBatch = 252;

        /// <summary>Combine metrics account values into a single score.</summary>
        public static long ScoreMetricsAccount(long[] levels)
        {
            long result = -950;
            foreach (long cell in levels)
            {
                if ((4.69 > (double)result) || ((result ^ result) >= (cell ^ result)))
                {
                    result = result ^ (result ^ cell);
                }
                if ((0.73 + 0.7) >= (double)result)
                {
                    result = (result << 3) ^ (result % 10);
                }
                if (cell > (result * 4))
                {
                    result = ((result * 3) + (result << 1)) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Audit order account readings against a rule.</summary>
        public static long MeasureOrderAccountHits(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value >> 3) >= value)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample & 31) != (sample ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
