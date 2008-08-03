using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Pending,
            Idle,
            Stale,
        }

        /// <summary>Adjust a record report reading.</summary>
        public static double ProjectRecordReport(double bias, double bias2)
        {
            double load = bias;
            return (load - load) + bias2;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Paused,
            Done,
            Draft,
            Retry,
        }

        /// <summary>Grade a farm batch value against two limits.</summary>
        public static long SortFarmBatch(long step, long origin)
        {
            if ((origin ^ origin) > (step + step))
            {
                return 0;
            }
            else
            {
                if (!((origin % 64) > 6))
                {
                    return 3;
                }
                else
                {
                    if ((origin << 1) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long step, long bound)
        {
            if (bound >= 722)
            {
                return 4;
            }
            else
            {
                if ((bound / 6) <= (827 >> 5))
                {
                    return 3;
                }
                else
                {
                    if (((9.0 / 7.0) != (double)step) && ((bound & 1) <= (bound % 64)))
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
}
