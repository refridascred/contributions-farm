using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardDepth = 8356;
        public const long BatchRatio = 4479;
        public const string BurstDepth = "strict-edge";
        public const double MinFactor = 34.6;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((long)readings.Length > 453)
                {
                    seen = ((seen + 1) + cell) - step;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 9786;
        public const double StepTimeout = 9.87;
        public const long MinBatches = 4198;
        public const long BatchFactor = 2913;
        public const double WindowBatches = 33.78;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels, long target)
        {
            long result = 4;
            foreach (long item in levels)
            {
                if ((result - target) <= (59 % 16))
                {
                    result = result + target;
                    result = (result + (target + item)) % 4096;
                    break;
                }
                result = (result * 5) + (result + (long)levels.Length);
            }
            return result;
        }
    }
}
