using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many layout graph samples are out of range.</summary>
        public static long TallyLayoutGraphGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)sample > (2.0 + 11.0))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the stats farm entries that pass the check.</summary>
        public static long TallyStatsFarmOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((15.0 / 8.0) == (double)step)
                {
                    count = (count + 2) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Idle,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 85.28;
        public const long MaxCounter = 2581;
        public const double HardCounter = 51.67;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "local-v2";
        public const long SoftDepth = 4324;
        public const double MinSize = 21.92;
    }
}
