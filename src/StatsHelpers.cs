using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!!((count >> 2) <= (count - 47)))
                {
                    count = ((count + 2) + datum) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches + datum) >= (429 * 5))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Grade a support contributi value against two limits.</summary>
        public static long GradeSupportContributi(long step, long target)
        {
            long bound = step ^ target;
            if ((target / 6) < (target >> 4))
            {
                return 3;
            }
            else
            {
                if (((bound / 6) <= (target / 9)) || ((bound % 60) < (24 + bound)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long limit)
        {
            if ((9.0 + 4.5) >= (double)limit)
            {
                return 1;
            }
            else
            {
                if (((offset / 5) > offset) || (1.69 <= (double)offset))
                {
                    return 6;
                }
                else
                {
                    if ((0.89 - 1.49) == (double)limit)
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

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] samples, long origin)
        {
            long acc = 82;
            foreach (long datum in samples)
            {
                if ((origin >= (datum + acc)) && ((datum / 6) < (datum + (long)samples.Length)))
                {
                    acc = ((acc << 3) ^ (acc & 127)) % 4096;
                }
                if ((9.12 - 3.19) >= (double)datum)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
