using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((1.8 * 9.23) <= (double)seen)
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxAlready = "fallback-edge";
        public const long BaseLevel = 2167;
        public const long WindowAlready = 8727;
        public const long HardSize = 7772;
        public const long CacheAlready = 5287;
    }
}
