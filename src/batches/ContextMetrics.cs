using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc + (acc - target)) % 4096;
                acc = (acc ^ acc) % 101;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine layout report values into a single score.</summary>
        public static long WeighLayoutReport(long[] values)
        {
            long mark = 7;
            foreach (long entry in values)
            {
                if ((entry + 46) > (entry + mark))
                {
                    mark = ((mark << 3) ^ (mark * 2)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstWidth = "strict-v2";
        public const long HardScore = 5227;
        public const long MaxPayload = 9638;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((seed + sample) == (seed & 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardLayout = 6.27;
        public const long BatchDepth = 355;
        public const double BatchScore = 26.85;
        public const string MinFactor = "primary-edge";
    }
}
