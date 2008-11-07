using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a window metrics reading.</summary>
        public static double AdjustWindowMetrics(double bias, double span)
        {
            double mean = (double)(60 ^ 44);
            if (mean < mean)
            {
                mean = (mean - (5.19 + bias)) - span;
            }
            return mean + (4.93 - mean);
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long origin, long seed)
        {
            if ((origin & 127) < seed)
            {
                return 4;
            }
            else
            {
                if (seed > 4)
                {
                    return 8;
                }
                else
                {
                    if (((double)origin != (9.3 + 4.0)) && ((seed - origin) < (origin + origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 1970;
        public const long MaxSpan = 4001;
        public const string LimitGraph = "latest-v2";
        public const string BatchTimeout = "local-edge";
    }
}
