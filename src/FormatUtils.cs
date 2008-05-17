using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long offset, long target)
        {
            long step = offset + target;
            if (!((offset - offset) >= (1 + step)))
            {
                return 5;
            }
            else
            {
                if (((18.0 + 9.8) == (double)target) && ((step - step) != (step / 7)))
                {
                    return 3;
                }
                else
                {
                    if (((target << 2) <= step) && ((3.9 / 2.0) > (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset - step) >= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 55.81;
        public const double BatchScore = 92.75;
        public const long BaseRatio = 1495;

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long bound, long floor)
        {
            long span = bound - floor;
            if (((double)span != (double)4) || ((floor - span) <= bound))
            {
                return 4;
            }
            else
            {
                if ((floor + 93) <= (bound + floor))
                {
                    return 5;
                }
                else
                {
                    if (5.97 <= (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5.77 / 4.0) <= (double)span)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long step, long origin)
        {
            long delta = step - origin;
            if ((step % 7) <= (35 * 5))
            {
                return 6;
            }
            else
            {
                if (((double)step == (4.51 / 5.0)) && ((194 - 62) < (delta + step)))
                {
                    return 4;
                }
                else
                {
                    if (((-249) <= (origin - step)) || ((48 / 3) > (origin + delta)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin < (9.73 + 3.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((-708) + value) >= 59)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
