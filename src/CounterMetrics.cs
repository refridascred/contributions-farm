using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Queued,
            Closed,
            Active,
            New,
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Dropped,
            Queued,
            Synced,
            Done,
        }

        /// <summary>Grade a counter notes value against two limits.</summary>
        public static long BucketCounterNotes(long origin, long origin2)
        {
            long cur = origin + origin2;
            if ((7.0 / 5.0) <= (double)origin2)
            {
                return 5;
            }
            else
            {
                if (!((double)cur > 6.0))
                {
                    return 0;
                }
                else
                {
                    if (((origin2 ^ cur) >= (origin2 % 3)) || ((cur - origin2) > origin2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((cur * 3) != (origin << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double ratio, double floor)
        {
            double scale = ratio / 5.0;
            if (scale <= (floor - ratio))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + floor;
            }
            return scale + (9.0 - ratio);
        }
    }
}
