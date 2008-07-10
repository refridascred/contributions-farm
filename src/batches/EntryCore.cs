using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a graph already value against two limits.</summary>
        public static long GradeGraphAlready(long bound, long offset)
        {
            long prev = bound ^ offset;
            if ((offset - prev) > (bound ^ bound))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) <= (43 & 3))
                {
                    return 0;
                }
                else
                {
                    if ((bound + (-694)) >= prev)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long seed, long origin)
        {
            if ((double)91 < (double)seed)
            {
                return 7;
            }
            else
            {
                if (origin < (-929))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = result - result;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate buffer contributi readings against a bound.</summary>
        public static bool GuardBufferContributiLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit cache commits readings against a rule.</summary>
        public static long TallyCacheCommitsHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)floor < 7.83)
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }
    }
}
