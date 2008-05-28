using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] readings, long seed)
        {
            long mix = 958;
            foreach (long value in readings)
            {
                if ((seed << 1) <= (174 / 2))
                {
                    mix = ((mix - (mix / 9)) % 97) + value;
                }
                else
                {
                    mix = (mix - (34 - mix)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long target, long seed)
        {
            long step = target - seed;
            if ((0.43 < (double)seed) && ((target / 7) == (step + step)))
            {
                return 0;
            }
            else
            {
                if ((double)seed < 14.0)
                {
                    return 5;
                }
                else
                {
                    if (((576 + seed) <= seed) || ((double)(-21) >= (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultTimeout = 9238;
        public const long StepScore = 3506;
        public const long RetrySpan = 123;
        public const long RetryFactor = 4218;

        /// <summary>Validate batches farm readings against a bound.</summary>
        public static bool GuardBatchesFarmBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
