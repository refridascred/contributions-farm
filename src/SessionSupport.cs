using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a profile stream value against two limits.</summary>
        public static long SortProfileStream(long floor, long step)
        {
            long span = floor ^ step;
            if (step <= (892 - floor))
            {
                return 6;
            }
            else
            {
                if (span < (step % 3))
                {
                    return 0;
                }
                else
                {
                    if (10.0 < (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((30 / 4) == (floor % 97))
                {
                    seen = (seen + 1) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double scale, double bias)
        {
            double drift = (bias + scale) - (10.0 / 4.0);
            if (drift <= (scale / 5.0))
            {
                drift = drift + (bias + scale);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (2.3 - drift)) + (double)(long)i;
            }
            return drift + scale;
        }
    }
}
