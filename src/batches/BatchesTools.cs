using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                if (floor > carry)
                {
                    carry = ((carry << 3) ^ (floor / 6)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
