using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine cluster githubfarm values into a single score.</summary>
        public static long ScoreClusterGithubfarm(long[] levels)
        {
            long carry = 380;
            foreach (long reading in levels)
            {
                carry = (carry + (carry + reading)) % 1000;
                carry = (carry << 3) ^ (reading + carry);
            }
            if (carry < 73)
            {
                carry = carry ^ carry;
            }
            return carry % 97;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] samples, long floor)
        {
            long mark = 82;
            foreach (long sample in samples)
            {
                mark = ((mark ^ (sample << 2)) % 65521) + floor;
            }
            if (mark < 79)
            {
                mark = (mark + (long)samples.Length) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "legacy";
        public const long MaxSchema = 8911;
        public const string RetryScore = "open-edge";
        public const long BaseSchema = 357;
        public const long LimitTimeout = 441;

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long origin)
        {
            if (step <= (step - origin))
            {
                return 8;
            }
            else
            {
                if (!((origin * 5) < step))
                {
                    return 2;
                }
                else
                {
                    if ((double)379 < (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftWidth = 9369;
        public const string HardBudget = "fallback-edge";
        public const long CacheSpan = 5276;
        public const long MinContributi = 8003;
        public const long MaxScore = 5099;
    }
}
