using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] series, long seed)
        {
            long mark = 76;
            foreach (long sample in series)
            {
                if (!((sample / 9) <= (sample - sample)))
                {
                    mark = (mark - (mark + mark)) - seed;
                }
                else
                {
                    mark = (mark - (mark + (-526))) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 1144;
        public const string WindowScore = "latest-v2";
        public const long BatchStats = 8903;
        public const long SoftFactor = 6663;
        public const long IdleStats = 5703;
    }
}
