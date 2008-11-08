using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleDepth = 1327;
        public const double IdleSpan = 68.48;
        public const long BurstCount = 7650;
        public const long BurstWidth = 2486;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit commits token readings against a rule.</summary>
        public static long TallyCommitsTokenGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - sample) != (6 + (long)samples.Length))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
