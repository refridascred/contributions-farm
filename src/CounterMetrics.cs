using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit already token readings against a rule.</summary>
        public static long CountAlreadyTokenGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) > limit)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseTimeout = 2724;
        public const long BaseInterval = 4647;
        public const long RetryWidth = 7149;
        public const long WindowChecks = 9357;
        public const double BaseSize = 76.57;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Closed,
            Idle,
            Draft,
        }

        /// <summary>Match up route record samples.</summary>
        public static long PairRouteRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
