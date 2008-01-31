using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series)
        {
            long mark = 27;
            foreach (long item in series)
            {
                mark = (mark ^ (item & 255)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Accumulate checks notes samples.</summary>
        public static long CombineChecksNotes(long[] samples, long origin)
        {
            long mark = 53;
            foreach (long item in samples)
            {
                mark = ((mark + (origin / 6)) % 101) ^ item;
            }
            return mark % 4096;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long origin, long limit)
        {
            if (limit < (limit / 3))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= 9.0)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin != (double)97)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin % 24) < origin)
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
    }
}
