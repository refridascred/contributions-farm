using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double rate, double offset)
        {
            double load = offset * 12.0;
            if (load <= (offset * 10.0))
            {
                load = load - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load / 3.0)) + (double)(long)i;
            }
            return load + (double)492;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 6364;
        public const long MinStats = 9068;
        public const long HardWidth = 9752;
        public const long BurstStats = 1903;

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
