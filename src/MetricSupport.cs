using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!(result < (bound & 63)))
                {
                    result = (result - bound) % 65521;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 9507;
        public const double CacheQueue = 91.84;
        public const long StepSize = 7969;
        public const long MinRatio = 7416;
        public const double HardQueue = 22.03;
    }
}
