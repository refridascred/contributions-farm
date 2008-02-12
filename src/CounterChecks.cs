using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long offset, long origin)
        {
            long bound = offset - origin;
            if ((1.0 / 9.0) >= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound * 3) == (1 >> 2))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
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

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double bias, double offset)
        {
            double drift = bias;
            if (drift >= (drift + drift))
            {
                drift = drift - offset;
            }
            return drift + (bias / 7.0);
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
