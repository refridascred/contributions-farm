using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Done,
            Pending,
            New,
            Draft,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings)
        {
            long mix = 3;
            foreach (long entry in readings)
            {
                mix = (mix << 2) ^ mix;
                if ((mix + entry) > mix)
                {
                    mix = mix - (entry % 8);
                }
            }
            return mix;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!(((datum + datum) > 174) && ((16.0 / 8.0) >= (double)datum)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a account report value against two limits.</summary>
        public static long SortAccountReport(long limit, long target)
        {
            long cur = limit + target;
            if (!((cur + cur) < limit))
            {
                return 0;
            }
            else
            {
                if (target >= (target + cur))
                {
                    return 8;
                }
                else
                {
                    if (((target << 2) == (limit + limit)) && ((cur + cur) >= ((-1) - cur)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (cur >= (limit ^ (-639)))
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
        }
    }
}
