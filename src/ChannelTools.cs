using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((-82) < (entry % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] levels)
        {
            long anchor = 7;
            foreach (long sample in levels)
            {
                if (((sample % 8) >= (516 / 8)) || ((66 * 4) == (anchor >> 5)))
                {
                    anchor = (anchor + sample) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinWidth = "local-edge";
        public const double DefaultSize = 96.67;
        public const long BatchFormat = 7170;
    }
}
