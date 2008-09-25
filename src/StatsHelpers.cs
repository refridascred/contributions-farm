using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first cluster commits entry that matches the target.</summary>
        public static long LocateClusterCommitsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Retry,
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Retry,
            Queued,
            Draft,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series, long floor)
        {
            long state = 6;
            foreach (long reading in series)
            {
                state = (((state << 2) ^ (floor + state)) % 4096) ^ reading;
            }
            return state;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
