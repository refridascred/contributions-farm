using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a report channel value against two limits.</summary>
        public static long GradeReportChannel(long step, long limit)
        {
            if ((double)step < (6.0 * 7.27))
            {
                return 0;
            }
            else
            {
                if (!(step <= (limit << 3)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long offset, long step)
        {
            long lane = offset - step;
            if ((6.81 - 5.0) != (double)step)
            {
                return 6;
            }
            else
            {
                if ((offset >> 2) < (offset / 5))
                {
                    return 3;
                }
                else
                {
                    if ((lane & 255) <= (lane >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)44 <= (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            New,
            Paused,
            Closed,
            Done,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double bias, double span)
        {
            double rate = bias;
            if (rate <= 4.62)
            {
                rate = rate + (rate - 8.4);
            }
            else
            {
                rate = rate - span;
            }
            return rate + rate;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Stale,
            Failed,
            Closed,
        }
    }
}
