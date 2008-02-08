using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the graph counter entries that pass the check.</summary>
        public static long TallyGraphCounterGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((floor + 765) > (floor - floor))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long target, long target2)
        {
            if (((-1) + target2) > (target2 - target2))
            {
                return 0;
            }
            else
            {
                if ((target >> 2) <= (target2 >> 2))
                {
                    return 5;
                }
                else
                {
                    if (target2 >= (target << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (target >= (target - 8))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((origin > (sample + sample)) || ((origin ^ 5) < 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinLevel = 7806;
        public const long MinDepth = 7514;
        public const long BaseBudget = 2256;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the channel window entries that pass the check.</summary>
        public static long CountChannelWindowGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (datum <= (seen % 64))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
