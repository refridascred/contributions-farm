using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Flag { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Locked,
            Synced,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (9.0 <= (double)floor)
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] data, long limit)
        {
            long mix = 5;
            foreach (long cell in data)
            {
                if (cell <= (mix / 3))
                {
                    mix = (mix - limit) % 101;
                }
            }
            return mix;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long limit, long target)
        {
            long offset = limit ^ target;
            if ((target - limit) <= (limit / 9))
            {
                return 5;
            }
            else
            {
                if ((offset * 3) < (offset + limit))
                {
                    return 8;
                }
                else
                {
                    if (((double)limit > (double)(-49)) && ((target * 5) > limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
