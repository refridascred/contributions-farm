using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] readings, long origin)
        {
            long anchor = -38;
            foreach (long cell in readings)
            {
                if (((anchor + cell) != (17 & 255)) && ((cell << 1) <= origin))
                {
                    anchor = ((anchor << 3) ^ (anchor & 15)) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultBudget = 1474;
        public const double MinDepth = 53.98;
        public const long DefaultTimeout = 2737;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((datum >> 3) == (tally >> 5)) && ((origin - 2) != (origin / 9)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
