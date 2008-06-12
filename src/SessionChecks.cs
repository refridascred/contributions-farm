using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepDepth = 7048;
        public const long SoftMetric = 1779;
        public const long BaseMetric = 6850;
        public const long BatchSize = 4591;
        public const long BatchMetric = 4555;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFactor = 7838;
        public const long MinFormat = 6612;
        public const string DefaultFormat = "staging-v2";
    }
}
