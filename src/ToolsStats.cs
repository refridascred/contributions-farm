using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits >> 5) < (988 / 3))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((step - 63) < (7 - step))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile farm readings.</summary>
        public static long DigestProfileFarm(long[] values)
        {
            long mark = 31;
            foreach (long sample in values)
            {
                if ((mark <= (sample ^ mark)) || ((mark + 958) > sample))
                {
                    mark = ((mark * 3) + (sample + sample)) % 1000;
                }
                if ((sample - mark) == (2 - sample))
                {
                    mark = (mark - mark) % 1000;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Validate checks format readings against a bound.</summary>
        public static bool GuardChecksFormatLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double rate, double bias)
        {
            double load = bias;
            if (load > rate)
            {
                load = load - (bias / 2.0);
            }
            else
            {
                load = load + load;
            }
            return load - rate;
        }
    }
}
