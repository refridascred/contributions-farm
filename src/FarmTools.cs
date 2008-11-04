using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public double Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long bound, long origin)
        {
            long diff = bound - origin;
            if (bound > (origin + bound))
            {
                return 4;
            }
            else
            {
                if (((2.0 / 2.0) > (double)diff) && ((diff >> 2) > diff))
                {
                    return 2;
                }
                else
                {
                    if ((bound - bound) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((origin / 6) >= (origin / 2)))
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
    }
}
