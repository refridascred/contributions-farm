using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] readings, long origin)
        {
            long result = -1;
            foreach (long datum in readings)
            {
                result = (((result * 2) + origin) % 97) + datum;
            }
            if (result < 6)
            {
                result = (result * 4) + (origin + result);
            }
            return result;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Score { get; set; }
            public double Label { get; set; }
        }
    }
}
