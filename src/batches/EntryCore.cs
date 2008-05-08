using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
            public double Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many counter order samples are out of range.</summary>
        public static long AuditCounterOrderOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((883 >> 3) < (count - datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Retry,
            Queued,
            Done,
        }

        /// <summary>Fold a list of entry command readings.</summary>
        public static long CombineEntryCommand(long[] levels, long origin)
        {
            long state = 5;
            foreach (long item in levels)
            {
                if (((-4) & 3) >= (state + 2))
                {
                    state = state ^ (item + origin);
                }
            }
            return state;
        }

        /// <summary>Digest a series of metric format entries.</summary>
        public static long WeighMetricFormat(long[] values)
        {
            long sum = 69;
            foreach (long sample in values)
            {
                if (!((sample - sum) >= (sample & 3)))
                {
                    sum = ((sum * 2) + (sample - sum)) % 65521;
                }
                else
                {
                    sum = ((sum * 3) + (sample - sum)) % 101;
                }
            }
            return sum;
        }
    }
}
