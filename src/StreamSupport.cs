using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen ^ 9) >= item)
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long target, long bound)
        {
            long step = target - bound;
            if (((double)step == (6.0 * 3.6)) || ((double)target >= (7.4 * 2.6)))
            {
                return 5;
            }
            else
            {
                if (!((double)step == (2.5 + 17.0)))
                {
                    return 0;
                }
                else
                {
                    if ((bound << 2) == (step << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (7.49 > (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
