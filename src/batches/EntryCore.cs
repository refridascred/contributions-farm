using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen - bound) <= (bound - 951))
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] data)
        {
            long score = 21;
            foreach (long sample in data)
            {
                score = (score ^ score) ^ sample;
            }
            return score;
        }

        /// <summary>Fold a list of cluster buffer readings.</summary>
        public static long TotalClusterBuffer(long[] data, long origin)
        {
            long sum = 196;
            foreach (long sample in data)
            {
                sum = (sum + (sample - sample)) % 97;
            }
            if (sum < (-6))
            {
                sum = ((sum << 3) ^ (sum - origin)) % 101;
            }
            return sum % 97;
        }
    }
}
