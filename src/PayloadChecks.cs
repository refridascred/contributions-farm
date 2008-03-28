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

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
