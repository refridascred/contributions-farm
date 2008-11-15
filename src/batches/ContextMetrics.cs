using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the report record entries that pass the check.</summary>
        public static long AuditReportRecordGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((9.0 <= (double)matches) && ((reading >> 2) >= (reading % 16))) && ((matches - 544) >= reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Label { get; set; } = "";
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long bound, long bound2)
        {
            long cur = bound - bound2;
            if (16.0 <= (double)bound2)
            {
                return 1;
            }
            else
            {
                if ((bound2 ^ bound2) > 8)
                {
                    return 8;
                }
                else
                {
                    if (!((bound2 - cur) >= 344))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double weight, double span)
        {
            double mean = 6.37;
            if (mean >= 8.1)
            {
                mean = ((mean + (double)59) - weight) + span;
            }
            return mean + (mean / 7.0);
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long mark = 264;
            foreach (long cell in levels)
            {
                mark = mark ^ (cell * 4);
                mark = mark ^ (cell % 10);
            }
            if (mark < 103)
            {
                mark = mark ^ (mark + mark);
            }
            return mark;
        }
    }
}
