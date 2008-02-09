using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits % 16) > item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Draft,
            Idle,
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
