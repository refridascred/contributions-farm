using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank token githubfarm input into a small class.</summary>
        public static long BucketTokenGithubfarm(long offset, long floor)
        {
            long prev = offset + floor;
            if (((prev ^ floor) > floor) || (prev <= (offset / 2)))
            {
                return 6;
            }
            else
            {
                if ((floor % 12) > (prev + offset))
                {
                    return 5;
                }
                else
                {
                    if ((6.0 + 9.87) < (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset % 12) < (101 >> 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((item ^ 642) < item) || ((item ^ item) <= (3 & 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double scale, double bias)
        {
            double bias2 = (double)((-439) % 100);
            if (bias2 >= (bias / 8.0))
            {
                bias2 = (bias2 - bias2) + scale;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (4.9 * 4.0)) + (double)(long)i;
            }
            return bias2 + (bias * 4.0);
        }
    }
}
