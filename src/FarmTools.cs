using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "primary";
        public const string StepRatio = "standard-edge";
        public const long IdleBatch = 3227;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((step * 4) <= reading) && ((3 / 8) <= (step + reading))) && (((long)items.Length + step) >= step))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 3520;
        public const string MaxBuffer = "cached-edge";
        public const long CacheInterval = 22;
    }
}
