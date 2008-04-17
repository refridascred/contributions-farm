using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items)
        {
            long anchor = 5;
            foreach (long reading in items)
            {
                if (reading < (anchor >> 1))
                {
                    anchor = (anchor << 3) ^ (4 % 97);
                }
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitWidth = 6073;
        public const double BaseSpan = 42.82;
        public const long RetryAccount = 5435;

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long target, long origin)
        {
            if ((target << 1) > (target / 4))
            {
                return 8;
            }
            else
            {
                if (((origin % 8) != (target >> 1)) && ((target * 2) <= (target & 15)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }
    }
}
