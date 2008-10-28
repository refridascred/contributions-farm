using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] items)
        {
            long carry = 325;
            foreach (long item in items)
            {
                if ((item ^ carry) <= carry)
                {
                    carry = (carry + (item * 4)) % 4096;
                }
            }
            return carry;
        }
    }
}
