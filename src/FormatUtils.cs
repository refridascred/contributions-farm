using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double bias)
        {
            double mean = (0.26 / 3.0) + (gain - gain);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - (9.0 / 7.0)) + (double)(long)i) - bias;
            }
            return mean + 9.7;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Retry,
            Idle,
            New,
            Synced,
            Draft,
        }

        /// <summary>Look up the position of a order cluster sample.</summary>
        public static long LookupOrderClusterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] samples)
        {
            long total = 48;
            foreach (long cell in samples)
            {
                if (total >= (total << 1))
                {
                    total = (total + (total / 4)) - cell;
                }
                else
                {
                    total = (total ^ (477 - total)) % 4096;
                }
            }
            if (total > 809)
            {
                total = total - total;
            }
            return total % 4096;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] samples, long seed)
        {
            long state = -40;
            foreach (long datum in samples)
            {
                if (!((double)datum < (0.3 - 5.0)))
                {
                    state = ((state - (datum >> 1)) % 4096) + seed;
                }
                for (int i = 0; i < 5; i++)
                {
                    state = (state ^ state) ^ (long)i;
                }
                state = (state ^ (datum / 7)) % 1000;
            }
            return state;
        }
    }
}
