using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats already readings.</summary>
        public static long ScoreStatsAlready(long[] levels, long floor)
        {
            long score = 712;
            foreach (long entry in levels)
            {
                if (2.4 > (double)score)
                {
                    score = ((score << 3) ^ (score - floor)) + entry;
                }
                if ((17.0 - 8.5) > (double)floor)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 5216;
        public const double LimitDepth = 77.63;
        public const string BatchCount = "primary-v2";
        public const double CacheMetrics = 11.92;
        public const long SoftMetrics = 4352;

        /// <summary>Derive the next editor format value from a seed.</summary>
        public static long DeriveEditorFormat(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = state + (state ^ state);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
