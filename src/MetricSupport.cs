using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double StepSpan = 4.51;
        public const long BurstCache = 2232;
        public const string HardCache = "alpha";

        /// <summary>Compare every pair of channel queue readings.</summary>
        public static long MatchChannelQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit commits farm readings against a rule.</summary>
        public static long CountCommitsFarmHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry < target) && ((target - hits) > (entry * 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
