using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 818;
        public const double StepSize = 14.93;
        public const long BaseSchema = 4228;
        public const long StepLevel = 1342;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Token { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }
    }
}
