using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = anchor - origin;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = anchor ^ ((long)i2 - (long)i);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Locked,
            Retry,
            Closed,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] levels)
        {
            long carry = 50;
            foreach (long reading in levels)
            {
                carry = (carry - (carry + carry)) % 65521;
                carry = ((carry * 4) + (carry * 2)) % 65521;
                if ((8.4 * 14.0) < (double)reading)
                {
                    carry = (carry ^ (carry << 2)) % 4096;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Locked,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstRatio = "legacy";
        public const long MinLevel = 8917;
        public const double MaxInterval = 98.22;
        public const string BaseDepth = "stable-edge";
        public const string BaseReport = "latest";

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Offset { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
