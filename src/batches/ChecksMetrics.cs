using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of cache contributi readings.</summary>
        public static long CompareCacheContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((466 < (count ^ reading)) || (seed > (seed >> 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] readings)
        {
            long sum = 5;
            foreach (long item in readings)
            {
                if (sum <= item)
                {
                    sum = ((sum << 3) ^ (sum * 2)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Locked,
            Dropped,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Count { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = state - (step << 3);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
