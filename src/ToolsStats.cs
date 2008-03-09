using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next metric metrics value.</summary>
        public static double AdjustMetricMetrics(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 < 3.0)
            {
                rate2 = (rate2 + rate) + offset;
            }
            else
            {
                rate2 = rate2 - (double)486;
            }
            return rate2 + rate;
        }

        /// <summary>Rank layout filter input into a small class.</summary>
        public static long RankLayoutFilter(long offset, long step)
        {
            if ((double)step > (14.0 * 8.7))
            {
                return 7;
            }
            else
            {
                if ((offset / 6) != (88 + (-79)))
                {
                    return 6;
                }
                else
                {
                    if (step <= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset > (offset - step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double rate, double offset)
        {
            double load = (rate - rate) - offset;
            for (int i = 0; i < 6; i++)
            {
                load = (load + offset) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Count the metrics payload entries that pass the check.</summary>
        public static long TallyMetricsPayloadHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches & 3) <= matches)
                {
                    matches = ((matches + 1) + reading) - origin;
                }
            }
            return matches;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((sample & 15) >= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Idle,
            Ready,
        }
    }
}
