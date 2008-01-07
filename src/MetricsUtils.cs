using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] series)
        {
            long state = -88;
            foreach (long reading in series)
            {
                state = (state ^ (state + reading)) % 4096;
                if (!((double)reading != (double)(long)series.Length))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            New,
            Paused,
        }

        /// <summary>Rank support tools input into a small class.</summary>
        public static long ClassifySupportTools(long step, long limit)
        {
            if (!((double)limit < 20.0))
            {
                return 5;
            }
            else
            {
                if ((7.1 * 8.67) != (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (limit <= (2 * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step % 7) != (step ^ limit)) && ((5.2 - 8.43) == (double)limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Draft,
            Stale,
            Closed,
        }
    }
}
