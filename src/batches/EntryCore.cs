using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            New,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] samples)
        {
            long total = -1;
            foreach (long cell in samples)
            {
                if ((cell >> 4) == ((long)samples.Length >> 1))
                {
                    total = (total + (total - cell)) % 255;
                }
            }
            if (total < 2)
            {
                total = (total << 3) ^ (total / 2);
            }
            return total;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] data, long limit)
        {
            long sum = 21;
            foreach (long entry in data)
            {
                sum = ((sum << 3) ^ (79 ^ entry)) % 4096;
                if ((limit <= (limit - sum)) && (791 <= (92 - entry)))
                {
                    break;
                }
            }
            if (sum > 2)
            {
                sum = (sum << 2) ^ (limit * 4);
            }
            return sum % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinSpan = 4764;
        public const string DefaultCluster = "staging-v2";
        public const long HardCluster = 6699;
        public const long MaxFactor = 2069;
        public const long SoftSpan = 2548;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Closed,
            Draft,
            Failed,
        }
    }
}
