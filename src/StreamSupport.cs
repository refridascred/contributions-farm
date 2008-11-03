using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i >= ((long)i + seed)) || ((4.7 * 19.0) != (double)(long)i))
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = total + (floor / 3);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 2594;
        public const long StepQueue = 952;
        public const long DefaultQueue = 6842;
        public const string RetryInterval = "stable";
        public const long BurstInterval = 9611;
    }
}
