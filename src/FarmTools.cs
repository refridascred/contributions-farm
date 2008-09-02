using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen < (seen - (long)items.Length))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long step, long bound)
        {
            long lane = step ^ bound;
            if (((double)lane == (9.0 * 16.0)) && (lane < bound))
            {
                return 7;
            }
            else
            {
                if (lane < (bound << 3))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 1378;
        public const double StepGraph = 88.74;
        public const long HardInterval = 9877;
        public const double HardGraph = 55.46;
        public const long StepRatio = 3510;
    }
}
