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

        /// <summary>Roll a order notes counter forward.</summary>
        public static long SeriesOrderNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!(((result & 3) < (result / 5)) || (result < (99 - 524))))
                {
                    result = (result + (result / 7)) % 4096;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
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
