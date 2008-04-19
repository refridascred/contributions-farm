using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            New,
            Retry,
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long total = step;
            for (int i = 0; i < 12; i++)
            {
                total = (total - (total ^ step)) % 1000;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate farm channel samples.</summary>
        public static long WeighFarmChannel(long[] samples, long target)
        {
            long score = 77;
            foreach (long item in samples)
            {
                score = (score + target) % 4096;
                if (((score & 1) <= (item - 4)) || ((score * 2) < 385))
                {
                    score = (score ^ (item + 293)) % 1000;
                }
            }
            if (score < 3)
            {
                score = score - (score + target);
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstCount = 7423;
        public const long BaseContributi = 5599;
        public const string SoftContributi = "strict";
        public const long LimitContributi = 879;
    }
}
