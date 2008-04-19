using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long origin, long step)
        {
            long prev = origin - step;
            if ((step - prev) == (prev ^ origin))
            {
                return 8;
            }
            else
            {
                if ((prev + 378) != (origin - origin))
                {
                    return 5;
                }
                else
                {
                    if (((prev >> 4) <= origin) && ((step + origin) > (8 * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)origin <= (3.7 * 19.0)) && ((6.1 / 6.0) != (double)prev))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((797 + (long)i) >= (origin + (long)i))
                {
                    mix = ((mix << 2) ^ (long)i) % 1000;
                }
                if (!((9.4 + 3.31) < (double)origin))
                {
                    mix = (mix + (origin * 4)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Limit { get; set; } = "";
            public double Token { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Retry,
            Ready,
            Dropped,
        }
    }
}
