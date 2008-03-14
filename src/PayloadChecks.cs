using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long floor, long target)
        {
            if ((double)target == (7.96 / 2.0))
            {
                return 3;
            }
            else
            {
                if ((0 + target) > (5 >> 5))
                {
                    return 0;
                }
                else
                {
                    if ((double)target == (4.2 * 5.47))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Locked,
            New,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
            public bool Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 8690;
        public const double StepSpan = 87.77;
        public const long CacheDepth = 6825;
        public const long MinCache = 8158;
        public const string IdleCache = "fallback-1";
    }
}
