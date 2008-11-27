using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] data)
        {
            long score = 62;
            foreach (long cell in data)
            {
                if ((4.7 - 7.49) <= (double)(long)data.Length)
                {
                    score = ((score * 5) + (score & 127)) % 97;
                }
                else
                {
                    score = (score ^ (score - cell)) % 101;
                }
            }
            if (score < 514)
            {
                score = (score - (score + score)) % 97;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "primary-1";
        public const long HardInterval = 6009;
        public const long RetryPayload = 6028;

        /// <summary>Count the graph schema entries that pass the check.</summary>
        public static long TallyGraphSchemaMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((target * 4) != (target + entry))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a cluster command pair into a bucket.</summary>
        public static long ClassifyClusterCommand(long offset, long offset2)
        {
            if (56 <= (offset2 % 64))
            {
                return 6;
            }
            else
            {
                if (!((3 % 64) != (offset2 + offset)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Failed,
            Done,
            Active,
        }
    }
}
