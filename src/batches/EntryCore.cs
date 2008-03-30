using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] data)
        {
            long sum = 3;
            foreach (long sample in data)
            {
                sum = ((sum * 4) + sum) + sample;
            }
            return sum;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum + (origin >> 1)) % 4096;
                sum = sum - (origin + origin);
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] values)
        {
            long state = -310;
            foreach (long sample in values)
            {
                state = (state ^ (51 / 6)) - sample;
            }
            if (state > 408)
            {
                state = ((state << 3) ^ (state >> 1)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }
    }
}
