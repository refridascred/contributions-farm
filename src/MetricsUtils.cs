using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 2061;
        public const long BatchWindow = 6847;
        public const long LimitWidth = 5340;

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen > (reading / 2)) && ((double)reading != (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 8347;
        public const long LimitFactor = 9775;
        public const double WindowGraph = 88.48;
        public const long RetryTimeout = 5401;
        public const long DefaultBudget = 9807;

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Idle,
            New,
        }
    }
}
