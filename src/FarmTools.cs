using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long offset, long origin)
        {
            long gap = offset ^ origin;
            if ((origin + 250) <= (origin - gap))
            {
                return 4;
            }
            else
            {
                if ((double)offset >= 5.32)
                {
                    return 0;
                }
                else
                {
                    if ((gap * 5) >= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((gap - gap) > (origin / 3))
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
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            Idle,
            Closed,
            Active,
            Retry,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double rate, double floor)
        {
            double scale = floor;
            if (scale <= (rate / 4.0))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - 8.52;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - floor) - (double)(long)i;
            }
            return scale - (rate + floor);
        }
    }
}
