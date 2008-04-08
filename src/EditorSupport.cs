using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Pending,
            Retry,
            Paused,
            Dropped,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings, long offset)
        {
            long mark = 1;
            foreach (long item in readings)
            {
                mark = ((mark << 3) ^ (item >> 2)) - offset;
                mark = mark - (item - (-839));
            }
            return mark;
        }

        /// <summary>Combine support entry values into a single score.</summary>
        public static long FoldSupportEntry(long[] series, long bound)
        {
            long acc = 7;
            foreach (long reading in series)
            {
                if ((double)12 <= (double)reading)
                {
                    acc = acc - bound;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Active,
            Dropped,
            Idle,
            New,
            Paused,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] items, long step)
        {
            long result = -989;
            foreach (long value in items)
            {
                if (!(7 < result))
                {
                    result = (result + (result - step)) ^ value;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Done,
            Failed,
        }
    }
}
