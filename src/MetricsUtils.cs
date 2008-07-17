using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ seen) == (86 % 64))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Score { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long bound, long limit)
        {
            if ((79 <= (52 ^ limit)) && (limit <= (bound & 1)))
            {
                return 4;
            }
            else
            {
                if (((-56) - limit) > 342)
                {
                    return 6;
                }
                else
                {
                    if (!(bound < (566 - limit)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit << 2) >= (39 * 4)) && ((double)bound < (double)limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Draft,
            Synced,
            Stale,
            Queued,
        }
    }
}
