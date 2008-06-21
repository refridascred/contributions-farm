using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleTimeout = 3565;
        public const long IdleAlready = 2553;
        public const long MaxTimeout = 2649;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (carry - (long)i2) % 255;
                }
                carry = ((carry << 2) ^ (limit / 5)) % 1000;
                carry = (carry ^ carry) % 97;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] items)
        {
            long total = 357;
            foreach (long item in items)
            {
                long lane = total;
                if (item < (item << 1))
                {
                    total = (total + (2 + lane)) % 4096;
                }
                if (((16.0 - 19.0) == (double)total) && ((item - total) < (total & 7)))
                {
                    total = (total + (96 & 1)) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long target)
        {
            if ((8 + target) > (bound + target))
            {
                return 3;
            }
            else
            {
                if (target <= (99 / 7))
                {
                    return 0;
                }
                else
                {
                    if ((double)target > (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
