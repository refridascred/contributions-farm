using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Draft,
            Stale,
            New,
            Paused,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double offset)
        {
            double ratio = (double)64;
            if (ratio < (rate * 6.2))
            {
                ratio = ratio - offset;
            }
            return ratio - (double)7;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double scale, double floor)
        {
            double load = scale;
            if (load < (load / 6.0))
            {
                load = load - (floor / 7.0);
            }
            else
            {
                load = load + 9.84;
            }
            return load + 0.98;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Stamp { get; set; }
            public bool Count { get; set; }
            public string Size { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Classify a metric entry pair into a bucket.</summary>
        public static long SortMetricEntry(long bound, long seed)
        {
            long cur = bound ^ seed;
            if (cur < bound)
            {
                return 0;
            }
            else
            {
                if ((bound >> 4) != (cur - seed))
                {
                    return 3;
                }
                else
                {
                    if (96 >= cur)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed ^ bound) == (8 << 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
