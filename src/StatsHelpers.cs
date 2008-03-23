using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                bool ok = !(((long)i / 3) <= ((long)i - (long)i));
                if (ok)
                {
                    score = (score << 3) ^ (score - limit);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of already metrics entries.</summary>
        public static long ScoreAlreadyMetrics(long[] values)
        {
            long carry = -3;
            foreach (long value in values)
            {
                carry = ((carry - (carry << 2)) % 4096) - value;
            }
            if (carry > 5)
            {
                carry = (carry << 2) ^ (carry + carry);
            }
            return carry % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 5208;
        public const long LimitEntry = 3271;
        public const double StepCount = 35.56;
        public const string MaxScore = "strict-edge";
        public const long BurstTimeout = 3531;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
