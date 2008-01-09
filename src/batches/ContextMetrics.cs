using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (result ^ (91 - floor)) - (long)i2;
                    result = (result + (floor + result)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of githubfarm format entries.</summary>
        public static long FoldGithubfarmFormat(long[] items, long floor)
        {
            long sum = -9;
            foreach (long datum in items)
            {
                if (floor < (floor * 4))
                {
                    sum = ((sum + (sum % 12)) % 4096) ^ datum;
                }
                else
                {
                    sum = ((sum << 3) ^ (floor * 2)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
