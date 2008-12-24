using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 1) < ((long)levels.Length << 3))
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] readings, long step)
        {
            long anchor = 984;
            foreach (long reading in readings)
            {
                if ((8 * 4) != (anchor * 4))
                {
                    anchor = ((anchor + (anchor << 1)) % 101) ^ reading;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor ^ step);
                }
            }
            if (anchor < 908)
            {
                anchor = (anchor ^ (step ^ anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 40.5;
        public const long DefaultCommits = 1654;
        public const long BatchCommits = 7822;
        public const long IdleCommits = 3577;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen > (seen - seen))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 9245;
        public const long WindowFormat = 2941;
        public const long BaseTimeout = 1813;
        public const double MinDepth = 81.61;
        public const long DefaultFormat = 1130;
    }
}
