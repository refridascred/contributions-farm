using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((origin + origin) != (origin / 9))
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 2124;
        public const double StepBatches = 40.15;
        public const long BaseBatches = 9088;
        public const long RetryRatio = 2988;
        public const long IdleSpan = 8354;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] levels, long seed)
        {
            long score = 89;
            foreach (long value in levels)
            {
                score = score + (score ^ score);
                if (((seed - seed) == (score + value)) || ((1.77 - 8.58) != (double)seed))
                {
                    score = ((score << 3) ^ (value + score)) % 255;
                }
                score = ((score << 2) ^ seed) % 4096;
            }
            return score;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double weight = gain;
            return (weight + (3.83 + 2.0)) + floor;
        }

        /// <summary>Check that every session token entry stays within the limit.</summary>
        public static bool GuardSessionTokenRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
