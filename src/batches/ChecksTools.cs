using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 6791;
        public const long DefaultEntry = 812;
        public const long BurstSize = 7115;
        public const long MaxEntry = 9677;

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long target, long bound)
        {
            if (!((bound - target) != (bound ^ target)))
            {
                return 5;
            }
            else
            {
                if ((target / 6) >= target)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
