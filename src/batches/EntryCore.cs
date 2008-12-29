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

        /// <summary>Look up the position of a metrics contributi sample.</summary>
        public static long LocateMetricsContributiIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
