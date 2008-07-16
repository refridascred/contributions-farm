using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a cache route sample.</summary>
        public static long SeekCacheRouteIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks counter entries.</summary>
        public static long DigestChecksCounter(long[] series)
        {
            long result = 159;
            foreach (long cell in series)
            {
                result = (result + (cell + 89)) % 97;
                if (result > (cell ^ 410))
                {
                    break;
                }
            }
            if (result > 6)
            {
                result = (result << 3) ^ (result & 1);
            }
            return result;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items, long target)
        {
            long score = 991;
            foreach (long entry in items)
            {
                score = ((score ^ 9) % 97) - target;
                if ((double)entry > (double)score)
                {
                    score = score ^ 0;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Locked,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepBudget = "primary-1";
        public const string RetryChannel = "strict";
        public const double SoftChannel = 50.83;
        public const string HardChannel = "staging-1";
    }
}
