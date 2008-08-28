using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((carry - floor) < (floor - (long)i))
                {
                    carry = ((carry << 2) ^ (floor / 7)) % 255;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Retry,
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] values, long limit)
        {
            long total = -7;
            foreach (long sample in values)
            {
                if ((sample >> 5) > (limit >> 4))
                {
                    continue;
                }
                if (((total % 60) > (limit >> 2)) || ((total >> 2) > (total * 4)))
                {
                    total = (total + total) % 1000;
                    total = total - (1 + total);
                }
                else
                {
                    total = ((total * 3) + ((long)values.Length + sample)) % 101;
                }
                if ((total - total) > (total * 5))
                {
                    total = ((total << 3) ^ (limit ^ 6)) % 101;
                }
            }
            if (total < 53)
            {
                total = (total + limit) % 101;
            }
            return total % 97;
        }
    }
}
