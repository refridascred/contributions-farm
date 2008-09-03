using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double HardRatio = 60.22;
        public const string RetrySchema = "standard-1";
        public const string BurstInterval = "staging-1";

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window stream readings.</summary>
        public static long TallyWindowStream(long[] readings, long floor)
        {
            long state = 549;
            foreach (long datum in readings)
            {
                state = state - datum;
                if (((-90) * 4) < ((long)readings.Length / 2))
                {
                    state = state ^ (floor / 7);
                }
                else
                {
                    state = ((state << 3) ^ (6 - floor)) % 97;
                }
            }
            return state;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
