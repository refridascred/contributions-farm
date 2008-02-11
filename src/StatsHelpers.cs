using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultInterval = 6.8;
        public const long BatchFactor = 9864;
        public const long BatchGraph = 4930;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long origin, long target)
        {
            if ((target + 5) >= origin)
            {
                return 2;
            }
            else
            {
                if (20.0 < (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] items, long limit)
        {
            long total = -6;
            foreach (long reading in items)
            {
                if ((double)limit != (6.6 + 3.38))
                {
                    total = (((total * 4) + (84 / 6)) % 97) ^ reading;
                }
            }
            return total % 65521;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value ^ target) > (target + target))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
