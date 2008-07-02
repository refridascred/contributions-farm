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

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double gain, double span)
        {
            double drift = (double)(911 + (-6));
            if (drift < (gain + gain))
            {
                drift = (drift + drift) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - gain) + (double)(long)i;
            }
            return drift + (double)936;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitWidth = 26.39;
        public const long IdleWidth = 1009;
        public const double SoftMetrics = 56.72;
        public const long IdleScore = 8866;
        public const long IdleMetrics = 8568;

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 + (double)771;
            }
            return ratio2 + (ratio - ratio2);
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
