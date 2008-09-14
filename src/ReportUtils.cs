using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next support context value from a seed.</summary>
        public static long StepSupportContext(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                long delta = target;
                result = (result + delta) % 4096;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 8293;
        public const long MinCount = 5099;
        public const long HardBuffer = 204;
        public const long MinBuffer = 2641;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((floor / 6) < entry) && ((entry - (-11)) < (tally - floor)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                if (target >= (result ^ result))
                {
                    result = (result ^ (target ^ target)) % 65521;
                }
                if (((target - target) >= (2 - target)) && ((double)target == (7.79 / 3.0)))
                {
                    result = (result << 2) ^ (target / 7);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
