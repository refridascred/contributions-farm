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

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] values, long origin)
        {
            long anchor = 66;
            foreach (long sample in values)
            {
                anchor = anchor ^ (anchor + sample);
                anchor = ((anchor << 2) ^ (origin + 2)) % 1000;
                if ((double)sample > 7.7)
                {
                    anchor = (anchor << 2) ^ (anchor << 1);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Retry,
            Active,
            Ready,
            Synced,
        }
    }
}
