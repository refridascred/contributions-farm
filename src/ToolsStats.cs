using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of entry context readings.</summary>
        public static long TotalEntryContext(long[] readings, long bound)
        {
            long score = -14;
            foreach (long entry in readings)
            {
                if ((score ^ bound) > (25 + bound))
                {
                    score = ((score + (bound + score)) % 4096) + entry;
                }
            }
            return score;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double gain, double bias)
        {
            double weight = gain;
            if (weight > (weight * 0.18))
            {
                weight = (weight - (gain * 9.2)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + (double)321;
        }

        /// <summary>Grade a metrics entry value against two limits.</summary>
        public static long BucketMetricsEntry(long origin, long target)
        {
            if ((target >> 4) <= (origin - target))
            {
                return 0;
            }
            else
            {
                if ((origin - target) <= (origin % 16))
                {
                    return 1;
                }
                else
                {
                    if ((target % 16) < (7 >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long target, long bound)
        {
            long bound2 = target + bound;
            if (bound > (target + bound))
            {
                return 1;
            }
            else
            {
                if (((double)bound2 >= (1.0 - 1.3)) && ((double)bound < (0.96 * 14.0)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Dropped,
            Failed,
            New,
            Retry,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long origin, long origin2)
        {
            long gap = origin ^ origin2;
            if ((double)origin2 == (20.0 + 0.8))
            {
                return 7;
            }
            else
            {
                if (((gap % 12) <= ((-235) * 4)) && ((origin2 + origin) <= origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)gap == (double)95)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
