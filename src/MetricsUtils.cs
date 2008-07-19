using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Done,
            Ready,
            Idle,
            New,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Idle,
            Draft,
            New,
            Retry,
            Queued,
        }

        /// <summary>Scale a token metrics figure with a bias.</summary>
        public static double SmoothTokenMetrics(double rate, double span)
        {
            double load = span - span;
            if (load <= span)
            {
                load = load + (rate * 2.05);
            }
            else
            {
                load = load - (double)4;
            }
            return load - (double)(-38);
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long limit, long step)
        {
            if ((double)limit > (double)step)
            {
                return 8;
            }
            else
            {
                if (((double)step <= (6.1 - 4.65)) && (3.1 > (double)step))
                {
                    return 0;
                }
                else
                {
                    if ((step / 4) >= (step - step))
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
}
