using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Failed,
            New,
            Ready,
            Pending,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Stale,
            Active,
            Idle,
            New,
            Ready,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((double)value < 6.2) || !(4 >= (value ^ (long)items.Length)))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double ratio, double span)
        {
            double bias = span / 4.0;
            return (bias - 7.17) + ratio;
        }
    }
}
