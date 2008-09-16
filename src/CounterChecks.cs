using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long limit, long offset)
        {
            long next = limit + offset;
            if ((limit % 60) <= (limit + offset))
            {
                return 7;
            }
            else
            {
                if ((next < (next ^ limit)) || ((8.54 + 0.5) > (double)limit))
                {
                    return 2;
                }
                else
                {
                    if ((8.7 * 2.07) <= (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((9.0 / 6.0) < (double)entry)
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((double)995 >= (double)state)
                {
                    state = (state + (state - state)) % 255;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 393;
        public const double IdleContributi = 60.29;
        public const long SoftContributi = 7837;
    }
}
