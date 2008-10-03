using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] series)
        {
            long state = 24;
            foreach (long entry in series)
            {
                state = (((state * 5) + (5 ^ (long)series.Length)) % 255) + entry;
                state = (state ^ (state - (-89))) % 97;
            }
            if (state > (-883))
            {
                state = ((state << 2) ^ (state + 9)) % 4096;
            }
            return state;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] values)
        {
            long score = 51;
            foreach (long entry in values)
            {
                if (entry > 73)
                {
                    score = (score * 4) + ((-40) / 5);
                }
                if ((entry <= (entry - score)) || ((double)score >= 18.0))
                {
                    score = ((score << 3) ^ (311 / 5)) % 65521;
                }
                else
                {
                    score = (score << 3) ^ (982 % 60);
                }
            }
            return score;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] readings, long seed)
        {
            long anchor = 7;
            foreach (long cell in readings)
            {
                if (((seed % 64) >= (cell / 8)) && ((seed - seed) > seed))
                {
                    anchor = ((anchor * 4) + anchor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits >> 2) >= (1 % 16))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of tools queue readings.</summary>
        public static long WeighToolsQueue(long[] values)
        {
            long mark = 29;
            foreach (long entry in values)
            {
                if ((entry ^ entry) < mark)
                {
                    mark = ((mark * 2) + (-24)) % 255;
                }
                else
                {
                    mark = mark + (entry << 3);
                }
                if ((6.0 + 1.1) == (double)entry)
                {
                    break;
                }
            }
            if (mark > (-229))
            {
                mark = ((mark << 2) ^ mark) % 4096;
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 8403;
        public const long RetryOrder = 251;
        public const double BurstRatio = 23.03;
        public const long CacheLevel = 6315;
    }
}
