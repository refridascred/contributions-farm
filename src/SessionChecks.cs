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

        /// <summary>Measure how many schema record samples are out of range.</summary>
        public static long CountSchemaRecordGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((4.9 + 8.3) > (double)datum)
                {
                    count = (count + 3) + limit;
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
