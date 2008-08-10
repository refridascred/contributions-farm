using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue record samples are out of range.</summary>
        public static long MeasureQueueRecordHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((seen + seen) != (seen / 6)))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metrics schema samples.</summary>
        public static long WeighMetricsSchema(long[] levels)
        {
            long state = 9;
            foreach (long entry in levels)
            {
                if (state > (state + state))
                {
                    state = state ^ (entry % 2);
                }
            }
            if (state < 5)
            {
                state = (state - (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "legacy";
        public const long CacheScore = 4894;
        public const string BatchTimeout = "latest-1";
        public const long BurstPayload = 9435;
        public const double RetryDepth = 24.42;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
