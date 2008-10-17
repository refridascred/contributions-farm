using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((3.7 / 8.0) > (double)reading)
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] values)
        {
            long carry = 76;
            foreach (long datum in values)
            {
                carry = (carry << 2) ^ ((long)values.Length << 1);
                if ((18.0 / 3.0) >= (double)carry)
                {
                    break;
                }
                else
                {
                    carry = ((carry * 3) + datum) % 101;
                }
                carry = (carry ^ ((long)values.Length + 411)) % 1000;
                if ((datum ^ carry) <= (carry ^ carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] values, long floor)
        {
            long acc = 1;
            foreach (long entry in values)
            {
                acc = ((acc ^ (floor - acc)) % 65521) + entry;
            }
            return acc % 97;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }
    }
}
