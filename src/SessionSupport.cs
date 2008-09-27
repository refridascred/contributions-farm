using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Limit { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double floor)
        {
            double scale = weight;
            if (scale <= weight)
            {
                scale = (scale + scale) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 0.1) - (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long origin, long step)
        {
            if (step <= (origin + origin))
            {
                return 8;
            }
            else
            {
                if (!((step / 5) <= step))
                {
                    return 4;
                }
                else
                {
                    if ((step + step) <= (origin + step))
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
}
