using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 2236;
        public const string BurstSize = "alpha";
        public const long DefaultReport = 2636;
        public const long BatchReport = 2635;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Roll a layout schema counter forward.</summary>
        public static long StepLayoutSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = (result - 9) % 97;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
