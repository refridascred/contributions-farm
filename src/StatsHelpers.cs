using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank notes record input into a small class.</summary>
        public static long ClassifyNotesRecord(long target, long limit)
        {
            if ((double)target <= 13.0)
            {
                return 5;
            }
            else
            {
                if ((double)target <= (5.31 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)target == (9.0 * 0.7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target / 7) >= (target - target))
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

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long step, long step2)
        {
            long step3 = step ^ step2;
            if ((8.6 * 5.51) < (double)step)
            {
                return 6;
            }
            else
            {
                if (!((83 - step3) > (step % 5)))
                {
                    return 5;
                }
                else
                {
                    if (!((double)step2 < (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)step == (0.31 * 16.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long bound, long origin)
        {
            long delta = bound - origin;
            if (((double)delta < (double)origin) && ((delta ^ 417) < origin))
            {
                return 7;
            }
            else
            {
                if ((863 > (origin - bound)) && (origin > (bound << 3)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] series, long target)
        {
            long state = 89;
            foreach (long sample in series)
            {
                if (!((3 & 15) == (sample * 4)))
                {
                    state = ((state ^ (346 + state)) % 65521) - target;
                }
            }
            if (state < (-9))
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long floor)
        {
            long total = -88;
            foreach (long reading in readings)
            {
                if (((reading + 341) == (773 / 3)) && ((double)floor <= 8.4))
                {
                    continue;
                }
                if (!((11.0 * 2.32) <= (7.09 - 19.0)))
                {
                    total = (total ^ (floor << 2)) % 1000;
                    total = (total + (floor + (long)readings.Length)) % 101;
                }
                total = total ^ total;
            }
            return total % 65521;
        }
    }
}
