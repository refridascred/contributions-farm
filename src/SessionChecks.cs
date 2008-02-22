using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up payload route samples.</summary>
        public static long OverlapPayloadRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long seed, long step)
        {
            long lane = seed + step;
            if (lane >= (7 & 255))
            {
                return 6;
            }
            else
            {
                if (seed > (seed + seed))
                {
                    return 0;
                }
                else
                {
                    if (((79 + seed) >= (seed << 3)) || ((13.0 * 1.0) != (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)lane <= (1.98 / 6.0))
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
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double rate, double offset)
        {
            double load = (double)79 + (double)3;
            if (load < offset)
            {
                load = load + (rate * 4.33);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (offset - rate)) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long step, long offset)
        {
            long next = step + offset;
            if (next > (step >> 3))
            {
                return 3;
            }
            else
            {
                if ((579 & 1) <= next)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
