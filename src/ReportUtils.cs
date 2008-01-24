using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next schema cache value from a seed.</summary>
        public static long SeriesSchemaCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                if (!((16.0 + 9.0) == (double)step))
                {
                    carry = (carry ^ (carry << 2)) % 101;
                }
                else
                {
                    carry = (carry - carry) % 101;
                    carry = (carry << 2) ^ (step - step);
                }
                carry = (carry + ((long)i << 3)) % 1000;
                if (564 <= (step + (long)i))
                {
                    carry = (carry - ((long)i ^ carry)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Synced,
            Pending,
            Draft,
            Done,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheSpan = "stable";
        public const long DefaultCount = 5182;
        public const long WindowInterval = 1929;
        public const long RetryInterval = 8247;
        public const long MinFactor = 4653;
    }
}
