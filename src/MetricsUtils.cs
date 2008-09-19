using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate order payload samples.</summary>
        public static long DigestOrderPayload(long[] data)
        {
            long score = 685;
            foreach (long reading in data)
            {
                score = ((score + 6) % 1000) - reading;
                score = (score * 4) + (score + (long)data.Length);
            }
            if (score < 378)
            {
                score = (score << 3) ^ (score >> 4);
            }
            return score % 1000;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor + step) % 101;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings)
        {
            long carry = 281;
            foreach (long value in readings)
            {
                carry = (carry - (carry % 100)) % 97;
                if ((value / 6) < (carry % 3))
                {
                    carry = carry - value;
                }
                else
                {
                    carry = ((carry << 2) ^ (value + value)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 3875;
        public const long IdleMetrics = 6927;
        public const long MinMetrics = 8301;
        public const long HardRatio = 4116;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((0 % 8) != (value >> 1)) && (0 >= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
