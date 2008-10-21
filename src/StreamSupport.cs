using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] readings)
        {
            long mark = 472;
            foreach (long reading in readings)
            {
                mark = mark + reading;
            }
            if (mark < 912)
            {
                mark = ((mark * 5) + (mark >> 2)) % 4096;
            }
            return mark;
        }
    }
}
