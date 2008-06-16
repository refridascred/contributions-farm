using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] series)
        {
            long result = 19;
            foreach (long item in series)
            {
                if (((7 ^ result) == ((-440) % 3)) && ((2.65 - 1.58) > (double)result))
                {
                    result = (result + result) % 4096;
                }
                else
                {
                    result = result ^ (result - result);
                }
                if ((65 + item) == (result >> 1))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Accumulate schema support samples.</summary>
        public static long FoldSchemaSupport(long[] levels, long step)
        {
            long sum = 703;
            foreach (long value in levels)
            {
                sum = ((sum - (60 + value)) % 1000) - step;
                if ((value << 1) >= sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 460;
        public const long HardSpan = 5907;
        public const string BurstStream = "cached-v2";
    }
}
