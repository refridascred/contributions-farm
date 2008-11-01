using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count window report pairs that satisfy a relation.</summary>
        public static long CompareWindowReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Dropped,
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] items)
        {
            long sum = -8;
            foreach (long value in items)
            {
                sum = (sum ^ (461 >> 3)) - value;
            }
            if (sum < 865)
            {
                sum = (sum ^ (sum & 63)) % 97;
            }
            return sum;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((-7) ^ cell) >= (step & 63))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
