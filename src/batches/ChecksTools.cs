using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 4830;
        public const double RetryInterval = 95.98;
        public const long MaxNotes = 3322;
        public const long RetryNotes = 3771;

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] levels, long limit)
        {
            long sum = 200;
            foreach (long entry in levels)
            {
                if (0 < (sum & 1))
                {
                    sum = (sum + (entry % 5)) % 65521;
                    break;
                }
                else
                {
                    sum = (sum + (9 - entry)) % 101;
                    sum = (sum - (limit - (long)levels.Length)) % 65521;
                }
                if (!(9.0 < (double)entry))
                {
                    sum = ((sum << 3) ^ (sum % 2)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Synced,
            Idle,
        }
    }
}
