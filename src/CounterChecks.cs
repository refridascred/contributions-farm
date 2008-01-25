using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next order account value from a seed.</summary>
        public static long RollOrderAccount(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 5) + result) % 97;
                result = ((result << 3) ^ ((long)i + result)) % 255;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Find the first entry session entry that matches the target.</summary>
        public static long SeekEntrySessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Flag { get; set; }
            public double Level { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            Draft,
            New,
            Pending,
            Idle,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item + floor) != (item * 5))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count token order pairs that satisfy a relation.</summary>
        public static long MatchTokenOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
