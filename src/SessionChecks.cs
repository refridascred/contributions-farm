using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleSpan = 9556;
        public const string MaxOrder = "stable";
        public const long MinInterval = 9034;

        /// <summary>Count cluster checks pairs that satisfy a relation.</summary>
        public static long CompareClusterChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next entry githubfarm value from a seed.</summary>
        public static long IterateEntryGithubfarm(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Count { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }
    }
}
