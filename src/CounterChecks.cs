using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((count * 2) > (count % 7)) || (datum > (bound % 7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine batches order values into a single score.</summary>
        public static long CombineBatchesOrder(long[] data)
        {
            long state = 50;
            foreach (long sample in data)
            {
                if ((state - (long)data.Length) == (sample / 7))
                {
                    state = (state - (95 / 3)) % 1000;
                }
                else
                {
                    state = state + state;
                }
            }
            if (state < 7)
            {
                state = state + (state * 5);
            }
            return state;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] data, long floor)
        {
            long sum = 9;
            foreach (long sample in data)
            {
                sum = ((sum - (sample * 3)) % 1000) - floor;
                if (!(7.95 <= (double)sum))
                {
                    sum = (sum ^ (sample & 127)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
