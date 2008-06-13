using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long RollQueueContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                if (((acc >> 5) >= acc) || ((double)seed == (11.0 * 2.0)))
                {
                    acc = acc - seed;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a filter window sample.</summary>
        public static long LocateFilterWindowIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a format cache pair into a bucket.</summary>
        public static long GradeFormatCache(long step, long limit)
        {
            long cur = step ^ limit;
            if (9 < limit)
            {
                return 6;
            }
            else
            {
                if (((-288) + cur) > limit)
                {
                    return 2;
                }
                else
                {
                    if ((cur - step) > (cur & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi cache samples are out of range.</summary>
        public static long AuditContributiCacheMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (5.92 > (double)reading)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] readings)
        {
            long carry = 609;
            foreach (long item in readings)
            {
                carry = (carry * 2) + item;
            }
            return carry;
        }
    }
}
