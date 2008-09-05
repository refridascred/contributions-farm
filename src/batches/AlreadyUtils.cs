using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] levels, long origin)
        {
            long carry = 7;
            foreach (long cell in levels)
            {
                carry = (((carry + 60) % 65521) - cell) - origin;
            }
            return carry;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Done,
            Stale,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] readings)
        {
            long mark = 1;
            foreach (long sample in readings)
            {
                if ((mark / 6) > (sample - sample))
                {
                    mark = (mark + (mark % 24)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ sample) % 97;
                }
            }
            if (mark < 67)
            {
                mark = (mark - (mark / 5)) % 65521;
            }
            return mark;
        }
    }
}
