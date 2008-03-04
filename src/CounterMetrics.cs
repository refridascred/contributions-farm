using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Derive the next payload queue value from a seed.</summary>
        public static long StepPayloadQueue(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] samples)
        {
            long anchor = 499;
            foreach (long value in samples)
            {
                if ((double)value >= (double)anchor)
                {
                    anchor = (anchor + (value - anchor)) % 255;
                    continue;
                }
                if ((7.0 <= (double)anchor) && ((double)732 > (double)value))
                {
                    anchor = anchor - anchor;
                }
                else
                {
                    anchor = (anchor << 2) ^ (53 / 4);
                    anchor = (anchor << 2) ^ (676 * 4);
                }
                anchor = anchor - (anchor & 1);
            }
            return anchor;
        }
    }
}
