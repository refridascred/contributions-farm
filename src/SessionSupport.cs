using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry * 3) < (182 << 1))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 2403;
        public const string WindowBuffer = "fallback-1";
        public const long IdleBuffer = 2299;
        public const long LimitSpan = 563;

        /// <summary>Count window stream pairs that satisfy a relation.</summary>
        public static long CompareWindowStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
