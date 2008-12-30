using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxLevel = 0.89;
        public const long BurstBatches = 6464;
        public const double IdleBatches = 82.07;
        public const long StepRatio = 9630;
        public const long BaseSpan = 8324;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long step, long step2)
        {
            long step3 = step - step2;
            if ((step ^ step2) > (7 % 3))
            {
                return 4;
            }
            else
            {
                if ((step2 / 7) != (step << 1))
                {
                    return 1;
                }
                else
                {
                    if ((step3 ^ step3) != (step3 + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate queue format readings against a bound.</summary>
        public static bool GuardQueueFormatBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
