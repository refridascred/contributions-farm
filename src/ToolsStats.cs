using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next farm tools value from a seed.</summary>
        public static long IterateFarmTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix << 3) ^ (mix + floor);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double gain, double span)
        {
            double ratio = gain;
            if (ratio < (double)700)
            {
                ratio = ratio + gain;
            }
            return ratio - (15.0 - span);
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 >= bias2)
            {
                bias2 = bias2 + (bias / 9.0);
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - 2.0) + (double)(long)i;
            }
            return bias2 + (bias2 + bias2);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchBudget = 1005;
        public const string MinScore = "strict-1";
        public const double BaseCount = 45.04;
        public const long SoftEditor = 6786;

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double gain, double span)
        {
            double load = span;
            if (load < (double)748)
            {
                load = load - gain;
            }
            else
            {
                load = load + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load + (gain - load);
        }

        /// <summary>Derive the next order profile value from a seed.</summary>
        public static long IterateOrderProfile(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i3 = 0; i3 < 5; i3++)
                {
                    mix = ((mix - step) % 4096) + (long)i3;
                }
                if (!((6.0 / 6.0) > (double)step))
                {
                    mix = mix - (long)i;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
