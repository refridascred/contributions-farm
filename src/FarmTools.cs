using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (7 <= (tally % 7))
                {
                    tally = ((tally + 3) - item) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 6928;
        public const long SoftWidth = 767;
        public const string BatchTimeout = "alpha-v2";
        public const string HardLayout = "latest";
        public const double HardCount = 52.99;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Done,
            Active,
            Paused,
        }
    }
}
