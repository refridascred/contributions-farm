using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long mix = -8;
            foreach (long item in levels)
            {
                mix = ((mix * 2) + mix) % 65521;
                mix = ((mix * 5) + (3 + mix)) % 97;
                mix = (mix - item) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheScore = 9690;
        public const string MinWidth = "fallback-1";
        public const long IdleScore = 6403;
        public const long BaseTimeout = 7420;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen > (seen / 4))
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
