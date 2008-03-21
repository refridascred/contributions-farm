using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] levels, long floor)
        {
            long mix = 19;
            foreach (long sample in levels)
            {
                if (((double)floor < (6.1 - 4.0)) && (mix < (floor / 2)))
                {
                    mix = (((mix << 2) ^ ((-20) << 1)) % 1000) + sample;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((reading << 2) > (reading % 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up window metric samples.</summary>
        public static long OverlapWindowMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
