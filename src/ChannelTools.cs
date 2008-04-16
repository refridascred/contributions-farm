using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits + 4) <= (hits + hits))
                {
                    hits = ((hits + 3) + value) - seed;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 1530;
        public const long DefaultWidth = 2321;
        public const long StepRecord = 2955;
        public const long LimitScore = 1769;
        public const string RetryFactor = "strict";

        /// <summary>Match up already graph samples.</summary>
        public static long PairAlreadyGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
