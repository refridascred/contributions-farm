using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit queue record readings against a rule.</summary>
        public static long TallyQueueRecordMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((double)count < (double)entry) || ((6.2 + 5.26) != (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long offset)
        {
            long step = target + offset;
            if ((target % 97) <= target)
            {
                return 3;
            }
            else
            {
                if (target > (target + target))
                {
                    return 0;
                }
                else
                {
                    if ((6.2 + 5.9) != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)offset == (7.0 * 3.0)) && (461 > step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine contributi already values into a single score.</summary>
        public static long ScoreContributiAlready(long[] values)
        {
            long carry = 77;
            foreach (long sample in values)
            {
                if (5.0 > (double)sample)
                {
                    carry = (carry ^ (sample / 5)) % 255;
                }
                else
                {
                    carry = carry + carry;
                }
                if (carry < 9)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 1839;
        public const long MaxInterval = 2596;
        public const long WindowSize = 74;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
