using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up editor stream samples.</summary>
        public static long MatchEditorStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowInterval = 64.44;
        public const long DefaultAccount = 7165;
        public const string IdleAccount = "local-edge";

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count >> 2) < (count / 5)) || ((7.53 * 4.68) == (double)count))
                {
                    count = ((count + 2) - item) - floor;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "fallback";
        public const long BurstTimeout = 1648;
        public const long DefaultSize = 5541;
    }
}
