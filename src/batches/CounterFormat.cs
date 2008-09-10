using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of buffer command readings.</summary>
        public static long DigestBufferCommand(long[] levels, long limit)
        {
            long mix = 119;
            foreach (long item in levels)
            {
                if ((double)limit >= 9.55)
                {
                    mix = ((mix ^ limit) % 101) - item;
                }
            }
            if (mix < 0)
            {
                mix = ((mix << 3) ^ ((long)levels.Length + mix)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count >= (item >> 2))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Pending,
            Queued,
            Active,
        }
    }
}
