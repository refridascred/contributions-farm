using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long bound, long step)
        {
            if ((step & 15) <= 31)
            {
                return 0;
            }
            else
            {
                if ((10 > bound) || (3 > (step + 542)))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound > (6.11 - 3.47))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step < 8.01)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                carry = carry + (limit - limit);
                carry = ((carry * 5) + (carry << 2)) % 101;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 8366;
        public const long StepSpan = 1427;
        public const double IdleContext = 38.22;
        public const long BaseContext = 4127;
        public const long RetryContext = 6598;
    }
}
