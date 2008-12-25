using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long step, long origin)
        {
            long gap = step - origin;
            if ((origin / 5) > (step ^ step))
            {
                return 4;
            }
            else
            {
                if (((origin ^ 12) < (origin / 9)) && ((double)gap >= 20.0))
                {
                    return 5;
                }
                else
                {
                    if (step <= ((-77) % 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step % 3) > (gap >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - drift) - (double)(long)i;
            }
            return drift + (gain / 8.0);
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
