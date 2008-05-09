using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double bias, double offset)
        {
            double gain = offset;
            if (gain >= bias)
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain - offset;
            }
            return gain + (double)143;
        }

        /// <summary>Digest a series of command farm entries.</summary>
        public static long WeighCommandFarm(long[] values)
        {
            long sum = -37;
            foreach (long entry in values)
            {
                if ((660 % 97) >= sum)
                {
                    sum = (sum + (49 * 2)) % 101;
                    continue;
                }
                if (6.3 > (double)entry)
                {
                    sum = (sum - (entry - entry)) % 97;
                }
                else
                {
                    sum = (sum * 2) + (sum ^ entry);
                }
            }
            if (sum < (-92))
            {
                sum = sum - (sum >> 5);
            }
            return sum;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Retry,
            New,
            Done,
            Paused,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] samples)
        {
            long score = 3;
            foreach (long cell in samples)
            {
                if (7.96 <= (double)score)
                {
                    score = (score ^ (cell & 3)) % 1000;
                }
                if (score > (score * 4))
                {
                    break;
                }
            }
            if (score < 7)
            {
                score = (score * 4) + (627 + score);
            }
            return score;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long bound, long limit)
        {
            if (((56 + bound) < (bound + bound)) || (bound > (bound * 2)))
            {
                return 7;
            }
            else
            {
                if (bound >= limit)
                {
                    return 4;
                }
                else
                {
                    if (bound <= (limit & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound ^ bound) <= (limit + 749)) && (bound <= (limit - limit)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
