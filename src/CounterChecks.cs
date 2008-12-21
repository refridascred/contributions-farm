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

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] samples, long bound)
        {
            long sum = 99;
            foreach (long item in samples)
            {
                sum = (sum * 2) + sum;
                if ((double)item > (double)bound)
                {
                    sum = (sum - bound) % 4096;
                }
            }
            return sum;
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

        /// <summary>Combine editor layout values into a single score.</summary>
        public static long ScoreEditorLayout(long[] data)
        {
            long anchor = 972;
            foreach (long item in data)
            {
                if (!((anchor >> 3) == (anchor & 3)))
                {
                    anchor = (anchor - (item + anchor)) % 65521;
                }
            }
            return anchor;
        }
    }
}
