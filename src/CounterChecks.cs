using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (floor >= (floor - 976))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value - 24) != (floor << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
