using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleBudget = 4779;
        public const long BaseScore = 2860;
        public const long CacheSession = 932;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((step >= (step + matches)) || (reading <= step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long origin, long step)
        {
            long slot = origin + step;
            if (slot > (step >> 3))
            {
                return 2;
            }
            else
            {
                if (slot > step)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
