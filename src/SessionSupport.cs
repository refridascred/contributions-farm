using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowBudget = 6748;
        public const double BurstInterval = 18.81;
        public const long MinTimeout = 8239;
        public const string SoftSpan = "open";
        public const long BurstLevel = 2738;

        /// <summary>Derive the next batch notes value from a seed.</summary>
        public static long StepBatchNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((double)total <= 5.95)
                {
                    total = (total << 2) ^ (limit + (long)i);
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
