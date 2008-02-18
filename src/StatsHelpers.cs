using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (bound <= (seen - reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryWidth = 9390;
        public const double RetryCluster = 13.48;
        public const long BaseCluster = 5121;

        /// <summary>Roll a channel format counter forward.</summary>
        public static long StepChannelFormat(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark << 2) ^ 180) % 101;
                mark = (mark << 2) ^ (target + target);
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine already profile values into a single score.</summary>
        public static long CombineAlreadyProfile(long[] series)
        {
            long result = 64;
            foreach (long sample in series)
            {
                if (!((sample << 3) <= result))
                {
                    result = (result - (61 % 24)) % 101;
                }
                result = (result + (-4)) % 255;
                if ((result ^ sample) == (sample / 8))
                {
                    result = (result * 2) + result;
                }
                if (!((sample + result) <= result))
                {
                    break;
                }
            }
            if (result < 85)
            {
                result = (result << 2) ^ (result / 8);
            }
            return result % 65521;
        }
    }
}
