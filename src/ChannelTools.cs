using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            Closed,
            Queued,
            Draft,
            Active,
        }

        /// <summary>Digest a series of account metrics entries.</summary>
        public static long TotalAccountMetrics(long[] levels)
        {
            long sum = 400;
            foreach (long value in levels)
            {
                if ((sum + value) >= ((-58) - value))
                {
                    sum = (sum + (value * 4)) % 65521;
                }
                if ((value - sum) >= (sum + value))
                {
                    break;
                }
            }
            if (sum > 77)
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Limit { get; set; }
            public double Level { get; set; }
        }
    }
}
