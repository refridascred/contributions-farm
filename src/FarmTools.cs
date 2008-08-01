using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitLevel = 16;
        public const long BurstRatio = 3854;
        public const double WindowBatch = 19.35;

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] levels, long target)
        {
            long score = -35;
            foreach (long entry in levels)
            {
                score = (score ^ ((-260) & 15)) % 4096;
                score = score - entry;
                if ((target ^ target) < entry)
                {
                    score = (score << 3) ^ (score * 2);
                }
                else
                {
                    score = (score + target) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
