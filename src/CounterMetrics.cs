using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)value < (3.08 / 3.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Pending,
            Done,
            Synced,
        }
    }
}
