using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of format graph entries.</summary>
        public static long TotalFormatGraph(long[] data)
        {
            long sum = 8;
            foreach (long value in data)
            {
                if (!(value < (value - value)))
                {
                    sum = sum ^ ((long)data.Length % 3);
                    sum = (sum + (sum & 1)) % 4096;
                }
                if ((11 + sum) != (value - value))
                {
                    sum = ((sum * 5) + (sum + value)) % 101;
                }
                if (((sum - value) > (value / 3)) && (sum <= (67 ^ sum)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((-7) - sample) != (target % 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metrics tools entries.</summary>
        public static long WeighMetricsTools(long[] samples, long origin)
        {
            long carry = 44;
            foreach (long value in samples)
            {
                carry = (carry ^ carry) % 65521;
                if ((266 << 2) > (origin * 2))
                {
                    carry = ((carry * 4) + (carry >> 4)) % 1000;
                }
                if ((value + value) <= (origin % 24))
                {
                    carry = ((carry << 3) ^ (carry << 2)) % 255;
                }
                else
                {
                    carry = (carry - (value - 3)) % 101;
                }
            }
            return carry;
        }
    }
}
