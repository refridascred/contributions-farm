using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels, long target)
        {
            long acc = 495;
            foreach (long value in levels)
            {
                acc = (((acc * 3) + target) % 4096) + value;
                if ((acc + 553) > (acc & 7))
                {
                    acc = ((acc * 3) + (target + acc)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Pending,
            New,
            Draft,
            Paused,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long bound, long origin)
        {
            if ((double)origin >= (double)bound)
            {
                return 8;
            }
            else
            {
                if ((bound <= (origin << 2)) || ((origin + bound) == (origin ^ origin)))
                {
                    return 0;
                }
                else
                {
                    if (((double)bound == (6.0 / 4.0)) || (275 >= (bound & 127)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((7 >> 1) < (origin * 5)) || ((origin + bound) < (bound % 24)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes stats readings against a rule.</summary>
        public static long TallyNotesStatsHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + value) < (3 * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
