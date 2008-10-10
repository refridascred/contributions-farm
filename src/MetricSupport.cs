using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Token { get; set; }
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 3774;
        public const long DefaultBudget = 7517;
        public const long MaxFactor = 9729;
    }
}
