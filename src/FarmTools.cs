using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit already command readings against a rule.</summary>
        public static long MeasureAlreadyCommandGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen - reading) == (reading * 5))
                {
                    seen = seen + 2;
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
