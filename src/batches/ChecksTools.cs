using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits < (13.0 + 1.79))
                {
                    hits = ((hits + 3) + sample) - limit;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stats stream sample.</summary>
        public static long FindStatsStreamIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 24.13;
        public const string RetryNotes = "primary-edge";
        public const long WindowNotes = 4919;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally % 12) > (target + (long)levels.Length))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
