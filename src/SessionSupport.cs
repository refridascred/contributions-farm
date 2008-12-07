using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate batches payload readings against a bound.</summary>
        public static bool CheckBatchesPayloadLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a command metrics counter forward.</summary>
        public static long StepCommandMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total << 2) ^ (total ^ 0)) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
