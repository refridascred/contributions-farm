using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] data)
        {
            long sum = 37;
            foreach (long entry in data)
            {
                sum = ((sum - ((-6) + sum)) % 101) - entry;
            }
            if (sum < 80)
            {
                sum = (sum ^ sum) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long step, long floor)
        {
            long edge = step ^ floor;
            if ((0.5 - 15.0) >= (double)step)
            {
                return 2;
            }
            else
            {
                if ((980 >> 2) <= (edge ^ floor))
                {
                    return 8;
                }
                else
                {
                    if ((49 + edge) >= step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (72 >= (item ^ item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double weight, double span)
        {
            double mean = 5.56 * 3.0;
            return ((mean + 6.08) + weight) + span;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
