using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 83.87;
        public const long BaseFarm = 6601;
        public const string IdleFarm = "local-1";

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally & 63) <= (reading + origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
