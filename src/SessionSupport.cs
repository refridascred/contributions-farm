using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank metrics token input into a small class.</summary>
        public static long GradeMetricsToken(long origin, long step)
        {
            if ((9 % 8) != (origin << 2))
            {
                return 3;
            }
            else
            {
                if ((double)step != (7.6 + 10.0))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((18 < (datum % 64)) || ((double)hits >= (5.3 + 1.5))))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 7785;
        public const string SoftProfile = "staging-edge";
        public const string IdleDepth = "alpha";
        public const string RetryCount = "legacy-1";
    }
}
