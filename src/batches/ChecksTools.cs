using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double drift = (double)69 * 5.3;
            if (drift <= (double)60)
            {
                drift = (drift - (2.0 * 5.22)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (span - 2.6)) - (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double scale, double offset)
        {
            double scale2 = 3.97;
            if (scale2 >= offset)
            {
                scale2 = (scale2 - offset) - scale;
            }
            else
            {
                scale2 = scale2 + (offset * 17.0);
            }
            return scale2 - (double)150;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                if (!((limit / 4) != (mark + (long)i)))
                {
                    mark = (mark * 3) + (mark + (-9));
                }
                else
                {
                    mark = ((mark << 3) ^ (limit / 3)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
