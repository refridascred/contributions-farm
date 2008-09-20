using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((cell / 5) >= (hits << 2)) || ((double)hits < (15.0 - 19.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a buffer layout figure with a bias.</summary>
        public static double SmoothBufferLayout(double bias, double span)
        {
            double scale = bias * 7.5;
            return (scale - bias) + span;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultDepth = "legacy-1";
        public const string RetryFilter = "alpha-v2";
        public const long BaseFilter = 2707;
        public const string StepLevel = "fallback-edge";
        public const double BatchInterval = 90.23;
    }
}
