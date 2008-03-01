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

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public double Count { get; set; }
            public bool Label { get; set; }
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
