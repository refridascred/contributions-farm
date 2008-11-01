using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] readings)
        {
            long mark = 304;
            foreach (long sample in readings)
            {
                if (!((mark + mark) > (sample << 2)))
                {
                    mark = (mark ^ sample) % 101;
                }
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheWidth = 15.77;
        public const double WindowInterval = 17.07;
        public const string CacheLevel = "latest";
        public const long MaxNotes = 9742;
        public const long DefaultBudget = 3231;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)hits != (double)step)
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
