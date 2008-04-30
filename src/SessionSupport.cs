using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many githubfarm entry samples are out of range.</summary>
        public static long MeasureGithubfarmEntryGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value > 8.7)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 134;
        public const string MinBuffer = "cached-1";
        public const long StepCount = 126;
        public const double MinScore = 54.57;

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix + (long)i) % 97;
                mix = mix ^ (long)i;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
