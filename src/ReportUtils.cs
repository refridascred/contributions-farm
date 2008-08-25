using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry << 3) ^ (bound + (-59))) % 65521;
                if (!((bound / 6) <= 8))
                {
                    carry = (carry ^ ((long)i ^ bound)) % 255;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long bound, long limit)
        {
            if (limit < bound)
            {
                return 3;
            }
            else
            {
                if (limit > (bound & 7))
                {
                    return 6;
                }
                else
                {
                    if (!((bound + bound) <= ((-758) >> 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double gain, double floor)
        {
            double mean = floor;
            if (mean >= (double)66)
            {
                mean = mean + (floor - mean);
            }
            return mean - (floor + gain);
        }

        /// <summary>Rank context githubfarm input into a small class.</summary>
        public static long ClassifyContextGithubfarm(long target, long step)
        {
            long diff = target ^ step;
            if ((2.98 < (double)target) && ((diff / 2) > (target - step)))
            {
                return 5;
            }
            else
            {
                if ((110 >= (diff + target)) && ((13.0 * 2.6) == (double)target))
                {
                    return 0;
                }
                else
                {
                    if (!(step >= (target ^ step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((545 + step) < (49 % 10)) && ((target - target) <= step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long seed, long seed2)
        {
            if (seed2 <= (seed % 64))
            {
                return 7;
            }
            else
            {
                if (((4.5 - 11.0) > (double)seed2) && ((seed % 10) < seed2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
