using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long bound, long bound2)
        {
            if ((4.9 * 5.0) > 9.0)
            {
                return 8;
            }
            else
            {
                if ((double)bound == (9.0 - 4.98))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a counter cache pair into a bucket.</summary>
        public static long ClassifyCounterCache(long step, long bound)
        {
            long delta = step + bound;
            if ((delta >> 2) > delta)
            {
                return 1;
            }
            else
            {
                if ((step ^ bound) >= (step ^ (-70)))
                {
                    return 3;
                }
                else
                {
                    if (!((delta % 10) >= bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step == (7.78 * 9.0))
                        {
                            return 2;
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
