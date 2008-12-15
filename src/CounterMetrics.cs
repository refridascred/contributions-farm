using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long bound, long step)
        {
            long lane = bound ^ step;
            if ((step + step) < step)
            {
                return 5;
            }
            else
            {
                if (bound >= (step + 42))
                {
                    return 1;
                }
                else
                {
                    if ((bound + step) <= lane)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((56 + step) > (bound + lane))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor - anchor) % 255) - (long)i2;
                    anchor = (anchor ^ anchor) % 4096;
                }
                anchor = (anchor - anchor) % 97;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i / 6) != (mix % 16))
                {
                    mix = ((mix * 3) + (floor - floor)) % 1000;
                    continue;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + mix)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double gain, double offset)
        {
            double bias = offset * 1.64;
            if (bias <= (1.0 - bias))
            {
                bias = (bias + bias) + gain;
            }
            return bias - 3.79;
        }
    }
}
