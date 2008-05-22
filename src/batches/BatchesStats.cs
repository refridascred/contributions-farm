using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] series)
        {
            long acc = 278;
            foreach (long value in series)
            {
                acc = (acc ^ (acc & 3)) ^ value;
            }
            return acc % 1000;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftWidth = 549;
        public const string StepWidth = "alpha";
        public const string IdleDepth = "staging-1";
        public const long StepEditor = 4964;
        public const string HardRatio = "legacy-1";
    }
}
