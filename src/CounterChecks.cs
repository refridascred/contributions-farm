using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((count << 2) <= (item + origin)) && (((double)item > (double)count) || ((count - (-435)) != (item ^ item))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first commits batch entry that matches the target.</summary>
        public static long LocateCommitsBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((3 >> 2) >= (sample + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] items)
        {
            long mix = 5;
            foreach (long datum in items)
            {
                if ((datum * 4) == (datum ^ mix))
                {
                    mix = (mix - (datum + datum)) % 4096;
                }
                if (((long)items.Length * 5) <= mix)
                {
                    break;
                }
            }
            if (mix < 30)
            {
                mix = (mix + mix) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
