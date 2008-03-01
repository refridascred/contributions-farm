using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Closed,
            Done,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                long gap = offset;
                gap = gap - (789 ^ (long)i);
                if ((gap ^ mix) < (217 ^ mix))
                {
                    gap = ((gap << 2) ^ (8 + gap)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate command metric samples.</summary>
        public static long WeighCommandMetric(long[] data)
        {
            long mix = 612;
            foreach (long item in data)
            {
                mix = (mix + (mix / 3)) ^ item;
            }
            return mix;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item * 3) <= (tally + tally))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }
    }
}
