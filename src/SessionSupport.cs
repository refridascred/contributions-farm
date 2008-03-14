using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry * 3) + ((long)i ^ limit);
                carry = (carry * 3) + carry;
                carry = (carry + carry) % 97;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
