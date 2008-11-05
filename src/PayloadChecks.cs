using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a report payload value against two limits.</summary>
        public static long ClassifyReportPayload(long offset, long step)
        {
            if (((20.0 / 4.0) > (double)step) && ((291 ^ step) > offset))
            {
                return 8;
            }
            else
            {
                if ((double)offset >= (18.0 * 7.0))
                {
                    return 4;
                }
                else
                {
                    if ((step + offset) < offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset - step) == (offset ^ 134))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Weight { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            Pending,
            Closed,
            Synced,
            Done,
        }

        /// <summary>Audit command contributi readings against a rule.</summary>
        public static long MeasureCommandContributiMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((1 * 4) == (hits - 2)) && !((reading + 78) > (hits & 31)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a entry filter reading.</summary>
        public static double ProjectEntryFilter(double ratio, double bias)
        {
            double load = 5.74;
            return (load + (ratio * 4.4)) + bias;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double offset)
        {
            double gain = (double)(30 - 0);
            if (gain > ratio)
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain + (offset / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - 8.0) + (double)(long)i;
            }
            return gain + (ratio - ratio);
        }
    }
}
