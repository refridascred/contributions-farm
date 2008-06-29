using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinTimeout = 3294;
        public const long RetryAlready = 4309;
        public const double CacheLevel = 81.41;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((double)seen < (0.31 + 3.29)) || ((8.0 / 3.0) >= (double)seen))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstInterval = 6151;
        public const long MinSize = 9922;
        public const long StepCounter = 3603;
        public const double LimitCounter = 41.77;
        public const long RetryLevel = 123;

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Draft,
            Stale,
            New,
        }
    }
}
