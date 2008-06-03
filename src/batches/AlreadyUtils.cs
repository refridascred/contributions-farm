using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftWidth = 7054;
        public const double HardCache = 74.66;
        public const double BatchFactor = 22.46;
        public const long BaseCache = 6100;
        public const string StepLevel = "standard-edge";

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + entry) < entry)
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 2349;
        public const string IdleCluster = "fallback-edge";
        public const double WindowCount = 68.27;
        public const string SoftDepth = "primary-v2";
    }
}
