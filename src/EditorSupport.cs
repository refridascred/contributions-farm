using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of cluster graph readings.</summary>
        public static long PairClusterGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            Ready,
            Done,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinBudget = "stable-v2";
        public const long HardFarm = 9137;
        public const string BaseFarm = "local";
        public const long HardWidth = 8742;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 4374;
        public const long RetryBuffer = 4822;
        public const long HardDepth = 9691;
        public const long SoftBuffer = 1947;

        /// <summary>Audit checks cluster readings against a rule.</summary>
        public static long TallyChecksClusterHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((11.0 * 1.92) < (double)datum))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
