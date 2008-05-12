using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((matches * 5) <= 8) && (((double)reading < (8.5 / 4.0)) || ((matches ^ reading) == (matches << 2))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate command token readings against a bound.</summary>
        public static bool CheckCommandTokenRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long floor, long step)
        {
            if ((step << 2) < step)
            {
                return 1;
            }
            else
            {
                if (828 <= (floor + step))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((seed - hits) == (cell >> 2)) && (((double)cell != (double)66) && ((double)(long)levels.Length <= (double)seed)))
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

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Locked,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Count batch layout pairs that satisfy a relation.</summary>
        public static long MatchBatchLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
