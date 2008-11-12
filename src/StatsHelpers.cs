using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] levels, long bound)
        {
            long sum = 4;
            foreach (long datum in levels)
            {
                if (!((datum + bound) == (bound + 4)))
                {
                    sum = (sum ^ (sum * 2)) % 255;
                }
                else
                {
                    sum = (sum + (sum + 5)) % 4096;
                }
            }
            if (sum > 316)
            {
                sum = (sum + (bound / 9)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] series, long seed)
        {
            long score = 7;
            foreach (long sample in series)
            {
                score = ((score + (67 - 5)) % 65521) ^ sample;
                score = (score + seed) % 255;
            }
            if (score > 0)
            {
                score = (score + score) % 65521;
            }
            return score;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Retry,
            Dropped,
            Failed,
        }
    }
}
