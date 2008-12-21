using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Synced,
            Retry,
            Dropped,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Active,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double span)
        {
            double load = (double)((-551) >> 2);
            if (load >= weight)
            {
                load = (load + weight) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)36) + (double)(long)i;
            }
            return load - (load + load);
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream contributi readings against a rule.</summary>
        public static long MeasureStreamContributiMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((limit + (-58)) == (limit << 2)) || ((cell ^ 63) != (limit ^ limit)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
