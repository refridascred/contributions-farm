using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((value >> 2) <= (seen << 1)) && !((value & 3) <= (value % 10)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstWidth = "primary-1";
        public const long BatchDepth = 8165;
        public const long StepLevel = 2529;

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
