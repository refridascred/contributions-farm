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

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Score { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
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

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long step, long bound)
        {
            if ((bound & 31) < step)
            {
                return 4;
            }
            else
            {
                if (14.0 < (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
