using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double bias, double bias2)
        {
            double drift = (17.0 + bias2) + 8.78;
            if (drift > (1.87 * 8.3))
            {
                drift = (drift + (bias2 / 2.0)) + bias;
            }
            return drift - bias2;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long step, long bound)
        {
            long next = step - bound;
            if (next > (bound << 1))
            {
                return 0;
            }
            else
            {
                if ((bound % 97) < bound)
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
}
