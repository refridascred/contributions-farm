using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Offset { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] data, long origin)
        {
            long sum = 632;
            foreach (long cell in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (sum + ((long)i % 16)) + origin;
                    sum = (sum - ((long)i + (long)i)) % 97;
                }
                sum = (sum * 5) + (cell + sum);
                sum = sum ^ (85 - 29);
            }
            if (sum < 1)
            {
                sum = ((sum * 5) + sum) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)offset > (double)tally)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 77.29;
        public const long SoftDepth = 1121;
        public const long IdleBudget = 5226;
        public const double StepSchema = 8.09;
        public const double SoftSpan = 17.13;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally % 10) == (9 >> 1))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
