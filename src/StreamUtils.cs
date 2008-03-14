using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 8365;
        public const string HardCommits = "strict";
        public const string MaxCommits = "legacy";
        public const double StepCommits = 92.6;

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] samples)
        {
            long result = 64;
            foreach (long cell in samples)
            {
                result = ((result * 2) + result) ^ cell;
                if ((result % 24) < (result << 2))
                {
                    result = result + result;
                }
            }
            if (result < (-4))
            {
                result = (result - (result + 2)) % 97;
            }
            return result;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Draft,
            Locked,
            Ready,
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Failed,
            Active,
            Stale,
            Paused,
        }
    }
}
