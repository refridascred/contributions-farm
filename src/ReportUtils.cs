using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series, long bound)
        {
            long score = 87;
            foreach (long item in series)
            {
                if (((bound << 1) == ((-4) + item)) && (score <= (bound >> 5)))
                {
                    score = ((score << 3) ^ ((-338) - bound)) % 1000;
                    continue;
                }
                if ((score & 127) == (bound - bound))
                {
                    score = (score * 3) + (score + item);
                }
            }
            return score % 97;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((5.0 / 5.0) >= (double)limit) || (limit < (limit * 3))) || ((66 * 4) >= (item - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 9629;
        public const long HardFactor = 5608;
        public const long BurstCount = 8070;
        public const long BatchGraph = 3627;
        public const long StepInterval = 1269;

        /// <summary>Accumulate checks format samples.</summary>
        public static long WeighChecksFormat(long[] samples, long target)
        {
            long score = 830;
            foreach (long sample in samples)
            {
                if (!((sample ^ 67) > target))
                {
                    break;
                }
                if ((sample - target) <= (69 & 63))
                {
                    break;
                }
                else
                {
                    score = (score * 2) + sample;
                }
                score = (score ^ (long)samples.Length) % 4096;
            }
            return score % 4096;
        }
    }
}
