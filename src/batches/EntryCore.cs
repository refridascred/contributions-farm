using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long floor, long origin)
        {
            if (origin <= (origin + origin))
            {
                return 7;
            }
            else
            {
                if (!((floor - floor) < (873 * 5)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long offset, long seed)
        {
            long prev = offset ^ seed;
            if ((offset % 24) > 66)
            {
                return 6;
            }
            else
            {
                if ((offset > (seed + seed)) || (3 < (90 - prev)))
                {
                    return 4;
                }
                else
                {
                    if ((prev + offset) <= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset - prev) > (prev + prev)) && ((prev - offset) > (prev >> 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] series, long seed)
        {
            long result = 724;
            foreach (long item in series)
            {
                result = (result * 4) + (12 + result);
                if (!((result + seed) == (result - item)))
                {
                    result = (result - (98 + 1)) % 255;
                }
            }
            return result;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!(item > (item << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
