using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long origin, long target)
        {
            long cur = origin - target;
            if ((cur << 2) <= 6)
            {
                return 8;
            }
            else
            {
                if (9.85 < (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin & 1) == (target & 255))
                    {
                        return 1;
                    }
                    else
                    {
                        if (1.9 > (double)cur)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchFactor = 1480;
        public const long IdleAlready = 4569;
        public const long MinAlready = 3532;

        /// <summary>Digest a series of metrics buffer entries.</summary>
        public static long TallyMetricsBuffer(long[] items)
        {
            long carry = 729;
            foreach (long item in items)
            {
                if ((9 ^ (long)items.Length) != (item & 3))
                {
                    carry = (carry << 3) ^ (item + carry);
                    carry = carry ^ (carry & 63);
                }
                if (item <= 54)
                {
                    carry = carry - 36;
                }
                else
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            if (carry < 27)
            {
                carry = (carry ^ carry) % 101;
            }
            return carry % 97;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }
    }
}
