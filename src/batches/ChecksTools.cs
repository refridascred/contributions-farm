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

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((matches + matches) < reading) || ((double)(long)items.Length <= (0.24 / 3.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
