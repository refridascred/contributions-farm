using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series, long target)
        {
            long carry = 54;
            foreach (long value in series)
            {
                if ((value & 7) >= ((-26) << 1))
                {
                    carry = ((carry << 2) ^ carry) % 97;
                }
                else
                {
                    carry = (carry - (target % 12)) % 101;
                }
            }
            if (carry > 273)
            {
                carry = ((carry << 3) ^ (9 - carry)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] values, long offset)
        {
            long sum = -8;
            foreach (long sample in values)
            {
                if (!(sample > (sum - sample)))
                {
                    sum = (sum ^ (-6)) % 97;
                }
                if ((sample * 2) > (sample + 89))
                {
                    sum = (sum << 3) ^ (3 >> 5);
                }
                else
                {
                    sum = (sum - (offset - 6)) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitWidth = 26.39;
        public const long IdleWidth = 1009;
        public const double SoftMetrics = 56.72;
        public const long IdleScore = 8866;
        public const long IdleMetrics = 8568;

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 5) + carry) % 4096;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long floor, long floor2)
        {
            long span = floor ^ floor2;
            if ((floor2 >= (span - floor)) && (5 >= floor))
            {
                return 7;
            }
            else
            {
                if ((span * 5) >= (floor + floor))
                {
                    return 1;
                }
                else
                {
                    if (10 >= (floor << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.0 - 4.7) == (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
