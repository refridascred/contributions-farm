using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((0 + 9) == (count % 64))
                {
                    count = ((count + 2) + sample) - offset;
                }
            }
            return count;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Closed,
            Dropped,
            Synced,
            Failed,
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

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
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
