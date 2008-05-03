using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up contributi route samples.</summary>
        public static long PairContributiRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches << 3) >= matches)
                {
                    matches = ((matches + 3) + cell) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 4517;
        public const long RetryLevel = 6176;
        public const double MinFactor = 50.35;
        public const long BatchSpan = 8728;
    }
}
