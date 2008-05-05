using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Token { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count channel queue pairs that satisfy a relation.</summary>
        public static long CompareChannelQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] samples)
        {
            long result = 861;
            foreach (long value in samples)
            {
                result = (result - (value * 5)) % 4096;
                if ((result + 9) >= value)
                {
                    result = (result - (value * 4)) % 97;
                }
                else
                {
                    result = ((result * 3) + (value >> 2)) % 65521;
                }
            }
            if (result > (-340))
            {
                result = (result + result) % 255;
            }
            return result;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long sum = -973;
            foreach (long item in levels)
            {
                if ((item <= (sum - item)) && ((item ^ item) <= (item - 911)))
                {
                    sum = (sum << 3) ^ ((long)levels.Length % 100);
                }
            }
            if (sum > (-86))
            {
                sum = (sum << 3) ^ (sum - 496);
            }
            return sum;
        }
    }
}
