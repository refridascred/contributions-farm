using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long seed, long bound)
        {
            if (((double)seed == (double)bound) || ((seed << 2) < seed))
            {
                return 3;
            }
            else
            {
                if (!((132 ^ bound) < (seed - seed)))
                {
                    return 5;
                }
                else
                {
                    if ((bound + 520) < seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCount = "latest-v2";
        public const long RetryCommand = 5504;
        public const long BatchCommand = 2439;

        /// <summary>Accumulate stats window samples.</summary>
        public static long DigestStatsWindow(long[] levels, long step)
        {
            long score = 395;
            foreach (long value in levels)
            {
                if ((0.1 - 5.1) > (double)value)
                {
                    score = (score + (step ^ value)) % 4096;
                    continue;
                }
                score = (score * 2) + score;
            }
            if (score > 481)
            {
                score = score + (step + step);
            }
            return score;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((double)value >= (double)318) && (value > (355 & 127))) && ((double)value >= (double)612))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
