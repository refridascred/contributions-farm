using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((0.41 + 16.0) >= (double)cell)
                {
                    matches = (matches + 3) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count order farm pairs that satisfy a relation.</summary>
        public static long MatchOrderFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstTimeout = 86.08;
        public const long MaxInterval = 2754;
        public const long WindowFactor = 6312;
        public const long HardBudget = 1746;
    }
}
