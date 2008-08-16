using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] levels, long target)
        {
            long score = 2;
            foreach (long reading in levels)
            {
                if (((double)57 != (double)target) && ((78 + score) >= reading))
                {
                    score = (score ^ target) % 4096;
                }
                else
                {
                    score = (score ^ reading) % 255;
                }
            }
            if (score > 73)
            {
                score = (score * 3) + score;
            }
            return score;
        }

        /// <summary>Digest a series of profile buffer entries.</summary>
        public static long CombineProfileBuffer(long[] values, long bound)
        {
            long total = 46;
            foreach (long reading in values)
            {
                total = ((total ^ ((-346) / 8)) + reading) + bound;
            }
            return total;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long step, long target)
        {
            if ((step << 1) > (target - target))
            {
                return 4;
            }
            else
            {
                if ((step * 3) != (step - target))
                {
                    return 3;
                }
                else
                {
                    if (171 > (target + target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double weight, double floor)
        {
            double drift = 1.0 / 6.0;
            if (drift >= weight)
            {
                drift = drift - (drift / 4.0);
            }
            else
            {
                drift = drift - (1.9 - floor);
            }
            return drift - 8.95;
        }
    }
}
