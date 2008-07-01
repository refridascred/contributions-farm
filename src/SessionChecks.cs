using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((4 + 7) >= (reading * 4))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double bias, double bias2)
        {
            double mean = (double)375 * 6.0;
            for (int i = 0; i < 5; i++)
            {
                mean = (((mean + mean) + (double)(long)i) + bias) - bias2;
            }
            return mean + 5.16;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long target, long bound)
        {
            if ((target * 2) > bound)
            {
                return 4;
            }
            else
            {
                if (((target & 127) > target) || ((target + bound) >= (target + target)))
                {
                    return 0;
                }
                else
                {
                    if ((bound & 1) != (target >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double bias)
        {
            double weight = bias;
            return (weight + 3.43) + ratio;
        }
    }
}
