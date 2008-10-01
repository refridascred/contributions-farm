using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((hits <= (reading + reading)) && (8.0 < (double)reading)) || ((reading * 4) != (hits % 10)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double rate, double span)
        {
            double ratio = (double)((-1) - 163);
            if (ratio >= (3.1 - span))
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (ratio / 2.0)) + (double)(long)i;
            }
            return ratio - (8.34 * 2.7);
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ target) % 101;
                sum = (sum + target) % 1000;
                if ((((long)i + (long)i) != (sum >> 3)) || (sum >= (target + sum)))
                {
                    sum = ((sum << 3) ^ target) % 255;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long step, long bound)
        {
            long lane = step - bound;
            if (lane >= (185 + lane))
            {
                return 4;
            }
            else
            {
                if ((lane + bound) != (step - 99))
                {
                    return 3;
                }
                else
                {
                    if (!((step - lane) == (bound / 8)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound % 12) <= 19)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm checks entry stays within the limit.</summary>
        public static bool GuardGithubfarmChecksLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
