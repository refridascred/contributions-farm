using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings, long limit)
        {
            long sum = 9;
            foreach (long item in readings)
            {
                sum = ((sum << 2) ^ (item + item)) % 255;
            }
            if (sum > 15)
            {
                sum = (sum + (limit >> 1)) % 4096;
            }
            return sum;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepScore = 4711;
        public const long BurstGithubfarm = 8694;
        public const double BaseSize = 45.96;
        public const double CacheSpan = 94.32;
        public const double SoftGithubfarm = 69.19;
    }
}
