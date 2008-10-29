using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            New,
            Draft,
            Stale,
            Queued,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long offset, long target)
        {
            if ((target * 5) >= (offset / 9))
            {
                return 8;
            }
            else
            {
                if ((7.0 * 7.5) == (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (!((target + 895) < 28))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset >= 0)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double bias, double bias2)
        {
            double weight = bias;
            if (weight < (double)382)
            {
                weight = (weight + (weight / 2.0)) - bias2;
            }
            return weight + (double)621;
        }

        /// <summary>Digest a series of queue support entries.</summary>
        public static long ScoreQueueSupport(long[] levels)
        {
            long mix = 9;
            foreach (long datum in levels)
            {
                if ((double)datum > (9.54 - 5.26))
                {
                    mix = (mix - (mix & 255)) % 97;
                }
            }
            return mix;
        }
    }
}
