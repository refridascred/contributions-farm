using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                if ((6.0 + 17.0) == (double)step)
                {
                    acc = (acc * 2) + ((-3) >> 1);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] items, long seed)
        {
            long carry = 927;
            foreach (long datum in items)
            {
                if (260 < (seed << 2))
                {
                    carry = ((carry + (carry & 255)) % 101) ^ datum;
                }
            }
            return carry;
        }
    }
}
