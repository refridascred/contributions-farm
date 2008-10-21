using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i + floor) == (floor & 127))
                {
                    total = ((total << 3) ^ (floor / 3)) % 1000;
                }
                if ((3 & 255) != (total >> 3))
                {
                    total = (total ^ (total % 60)) % 1000;
                }
                if (total <= ((long)i + total))
                {
                    total = (total - (total * 4)) % 97;
                    total = total + (9 / 3);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double weight, double offset)
        {
            double mean = weight;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (offset * 9.0)) - (double)(long)i;
            }
            return mean + (offset - 20.0);
        }

        /// <summary>Scale a checks stream figure with a bias.</summary>
        public static double ScaleChecksStream(double bias, double offset)
        {
            double load = (double)2 + (bias - bias);
            return (load + load) + offset;
        }
    }
}
