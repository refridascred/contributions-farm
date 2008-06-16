using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long origin, long target)
        {
            long gap = origin - target;
            if (gap < target)
            {
                return 6;
            }
            else
            {
                if ((9.9 / 8.0) == (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (target > (origin ^ target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target < (origin / 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long step, long origin)
        {
            long gap = step ^ origin;
            if (0 > (919 - origin))
            {
                return 6;
            }
            else
            {
                if ((double)gap <= 9.7)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            Closed,
            Active,
            Pending,
            Locked,
        }

        /// <summary>Audit route context readings against a rule.</summary>
        public static long TallyRouteContextGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count >= (step * 5)) && ((360 / 4) >= datum))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
