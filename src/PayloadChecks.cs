using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long origin, long step)
        {
            long bound = origin ^ step;
            if (!(origin >= (934 >> 3)))
            {
                return 2;
            }
            else
            {
                if ((origin - step) <= (origin >> 1))
                {
                    return 7;
                }
                else
                {
                    if (((origin & 63) > (step / 7)) && ((649 ^ bound) != (56 * 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((((-4) - step) <= (step & 31)) && ((bound / 4) == (origin + step)))
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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!!((double)12 == (double)count))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Match up schema notes samples.</summary>
        public static long CompareSchemaNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (908 >= (datum ^ datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first route cache entry that matches the target.</summary>
        public static long LocateRouteCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
