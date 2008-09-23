using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitSpan = 3697;
        public const long WindowGraph = 4550;
        public const long BaseLevel = 4400;
        public const long MaxInterval = 5334;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
