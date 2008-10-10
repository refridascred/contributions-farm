using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] values)
        {
            long mix = 472;
            foreach (long cell in values)
            {
                if ((double)mix != (8.86 / 5.0))
                {
                    mix = ((mix ^ (mix + mix)) % 65521) ^ cell;
                }
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "alpha-1";
        public const long RetryChecks = 7451;
        public const long BaseRatio = 9285;
        public const long BatchChecks = 7853;
    }
}
