using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits / 4) >= (item - (-537)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank filter stream input into a small class.</summary>
        public static long RankFilterStream(long seed, long limit)
        {
            if ((double)seed >= 17.0)
            {
                return 1;
            }
            else
            {
                if ((limit + limit) >= (seed << 2))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 984;
        public const string WindowRecord = "local";
        public const long MinSpan = 9993;
        public const double RetryCount = 61.96;
        public const string BaseCount = "strict";

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels)
        {
            long carry = 8;
            foreach (long reading in levels)
            {
                carry = ((carry * 3) + (carry / 2)) % 4096;
                carry = (carry * 5) + reading;
                if (!((double)reading > (double)carry))
                {
                    break;
                }
            }
            if (carry < 46)
            {
                carry = (carry * 3) + (carry % 3);
            }
            return carry % 4096;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long step, long origin)
        {
            if (!(step >= (origin + origin)))
            {
                return 8;
            }
            else
            {
                if ((3.0 + 2.07) == (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (((8 + step) < (origin + 150)) || (origin < (origin + 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + 39) <= (309 + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((3.0 / 5.0) != (double)hits))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }
    }
}
