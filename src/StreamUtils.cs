using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Active,
            Queued,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if ((13.0 - 1.12) != (double)target)
                {
                    total = (total * 4) + (total + total);
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of buffer layout entries.</summary>
        public static long WeighBufferLayout(long[] values)
        {
            long carry = 7;
            foreach (long datum in values)
            {
                if (carry > (-8))
                {
                    carry = ((carry ^ carry) % 97) - datum;
                }
            }
            if (carry > 46)
            {
                carry = ((carry * 5) + carry) % 101;
            }
            return carry;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ sample) <= (tally / 9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
