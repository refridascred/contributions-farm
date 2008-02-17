using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitNotes = "stable-v2";
        public const long RetryLevel = 6312;
        public const long CacheWidth = 326;
        public const long BatchNotes = 923;
        public const double MinNotes = 23.44;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long offset, long origin)
        {
            if ((offset ^ offset) == (offset - origin))
            {
                return 2;
            }
            else
            {
                if (((double)origin == (15.0 * 3.53)) && ((double)origin > (3.0 + 5.48)))
                {
                    return 1;
                }
                else
                {
                    if ((offset >> 4) >= (48 + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
