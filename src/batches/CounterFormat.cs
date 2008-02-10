using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] items, long floor)
        {
            long acc = 5;
            foreach (long sample in items)
            {
                acc = acc - (floor - acc);
                if (sample >= (acc >> 4))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Active,
            Queued,
            Done,
            Pending,
            Idle,
        }
    }
}
