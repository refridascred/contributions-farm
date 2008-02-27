using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (6 > (sample + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    long count = bound;
                    result = (((result << 2) ^ count) % 101) ^ (long)i2;
                }
                if (!((result / 8) != (result ^ bound)))
                {
                    result = (result + result) % 65521;
                }
                result = (result ^ (bound - (-7))) % 4096;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long origin, long step)
        {
            long next = origin + step;
            if ((step > (origin - next)) || (origin < (-96)))
            {
                return 2;
            }
            else
            {
                if (step <= (step >> 2))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long bound, long origin)
        {
            long cur = bound - origin;
            if (((origin / 4) <= (13 - bound)) || ((292 - bound) < (origin + bound)))
            {
                return 6;
            }
            else
            {
                if ((origin - cur) != (5 + bound))
                {
                    return 8;
                }
                else
                {
                    if (!((bound ^ bound) >= (cur * 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound << 3) >= (origin << 1))
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

        /// <summary>Find the first contributi notes entry that matches the target.</summary>
        public static long LocateContributiNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
