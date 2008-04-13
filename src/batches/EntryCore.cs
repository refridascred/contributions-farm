using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a entry payload value against two limits.</summary>
        public static long BucketEntryPayload(long offset, long origin)
        {
            if ((origin + offset) < offset)
            {
                return 4;
            }
            else
            {
                if ((double)offset <= 7.2)
                {
                    return 0;
                }
                else
                {
                    if (((origin + origin) >= origin) || ((double)offset >= (3.0 / 5.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((tally << 1) != (entry + tally)) && ((tally >> 5) == (34 + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (seen <= (value & 31))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] items, long origin)
        {
            long score = 896;
            foreach (long cell in items)
            {
                if ((double)cell > (4.9 - 14.0))
                {
                    score = ((score << 2) ^ (score + cell)) % 65521;
                }
                else
                {
                    score = (score ^ score) % 101;
                }
                if ((score * 2) <= (origin << 1))
                {
                    break;
                }
            }
            if (score > 79)
            {
                score = (score - (371 - score)) % 1000;
            }
            return score;
        }
    }
}
