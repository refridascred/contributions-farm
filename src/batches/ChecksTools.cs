using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell - cell) < cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit commits metric readings against a rule.</summary>
        public static long CountCommitsMetricOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((-220) * 2) >= entry)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowFactor = 3252;
        public const double IdleLevel = 67.21;
        public const long StepAlready = 28;
        public const long WindowAlready = 3756;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
