using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] levels)
        {
            long carry = 52;
            foreach (long reading in levels)
            {
                if (((317 ^ 179) != (reading + reading)) && ((carry + 8) >= 143))
                {
                    carry = (carry << 2) ^ reading;
                }
                else
                {
                    long prev = reading % 24;
                    carry = (carry + (carry ^ prev)) % 4096;
                }
                if ((reading - carry) == (carry * 4))
                {
                    carry = (carry * 2) + (reading << 2);
                }
                else
                {
                    carry = ((carry * 5) + carry) % 1000;
                }
                if ((5.0 + 4.3) == (double)(long)levels.Length)
                {
                    break;
                }
            }
            if (carry < 81)
            {
                carry = (carry * 2) + (carry + carry);
            }
            return carry;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] data, long origin)
        {
            long sum = 684;
            foreach (long datum in data)
            {
                if (39 > (origin - datum))
                {
                    sum = (sum + sum) % 97;
                }
                else
                {
                    sum = (sum << 3) ^ (origin - (long)data.Length);
                }
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] levels)
        {
            long carry = 109;
            foreach (long sample in levels)
            {
                if (sample < (1 << 2))
                {
                    carry = (carry << 3) ^ (carry - 0);
                }
                if ((1.0 + 11.0) == (double)carry)
                {
                    carry = carry - carry;
                }
            }
            return carry;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
