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

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultScore = 7527;
        public const string BaseContext = "stable-v2";
        public const long BatchContext = 8397;
        public const long BurstDepth = 3706;
        public const long BurstFactor = 5575;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item >= 18.0)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
