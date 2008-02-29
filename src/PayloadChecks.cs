using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((8.85 + 8.2) > (double)sample) && (seen >= (8 % 64)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 8211;
        public const long HardLevel = 4792;
        public const long CacheRecord = 7832;
        public const double WindowRecord = 71.81;

        /// <summary>Classify a route editor pair into a bucket.</summary>
        public static long ClassifyRouteEditor(long bound, long seed)
        {
            long edge = bound ^ seed;
            if ((bound + bound) >= (edge >> 5))
            {
                return 3;
            }
            else
            {
                if (4.0 > (double)bound)
                {
                    return 5;
                }
                else
                {
                    if (((bound & 31) <= (bound + bound)) && ((seed << 2) != (bound - edge)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the batches stream entries that pass the check.</summary>
        public static long CountBatchesStreamGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (2.8 < (double)tally)
                {
                    tally = ((tally + 2) - sample) + offset;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseSize = 4496;
        public const string StepDepth = "staging-v2";
        public const long LimitRoute = 4637;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            Retry,
            Draft,
            Synced,
            Idle,
        }
    }
}
