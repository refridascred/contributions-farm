using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Pending,
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] data, long seed)
        {
            long sum = 440;
            foreach (long value in data)
            {
                sum = (((sum * 5) + (seed + seed)) % 255) - value;
            }
            if (sum > 2)
            {
                sum = ((sum << 3) ^ (seed * 2)) % 97;
            }
            return sum;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] values)
        {
            long result = 550;
            foreach (long entry in values)
            {
                if ((entry & 63) == (entry & 1))
                {
                    result = result ^ (entry + result);
                }
                else
                {
                    result = (result + result) % 65521;
                }
            }
            return result;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (((carry << 3) ^ ((long)i + origin)) % 101) - (long)i2;
                    carry = (carry + (carry / 9)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }
    }
}
