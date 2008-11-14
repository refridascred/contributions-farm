using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up metrics tools samples.</summary>
        public static long PairMetricsToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a layout route value against two limits.</summary>
        public static long BucketLayoutRoute(long target, long step)
        {
            long step2 = target + step;
            if ((step2 << 1) > step)
            {
                return 7;
            }
            else
            {
                if (target > (target * 2))
                {
                    return 5;
                }
                else
                {
                    if ((0.85 * 8.4) == (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if (step >= 159)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((993 * 3) > item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((6 * 2) <= (cell % 24))
                {
                    hits = (hits + 1) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
            public double Flag { get; set; }
        }
    }
}
