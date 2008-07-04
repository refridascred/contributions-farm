using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples)
        {
            long sum = -87;
            foreach (long reading in samples)
            {
                sum = (((sum << 2) ^ sum) % 4096) - reading;
            }
            return sum % 4096;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long limit, long seed)
        {
            long delta = limit + seed;
            if ((double)limit < (0.91 * 2.56))
            {
                return 4;
            }
            else
            {
                if (((7.9 * 2.5) < (double)delta) || ((297 + seed) != (seed - delta)))
                {
                    return 0;
                }
                else
                {
                    if ((double)2 != (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count record token pairs that satisfy a relation.</summary>
        public static long CompareRecordTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchCount = "strict-1";
        public const double BatchEditor = 94.79;
        public const double CacheSpan = 89.11;
    }
}
