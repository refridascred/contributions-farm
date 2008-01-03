using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the window report series from a seed.</summary>
        public static long SeriesWindowReport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark << 2) ^ offset) % 255;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] readings, long offset)
        {
            long carry = 36;
            foreach (long value in readings)
            {
                if (((value / 5) != (2 + carry)) && (value >= (value & 255)))
                {
                    break;
                }
                if ((offset - offset) < ((long)readings.Length + carry))
                {
                    carry = carry ^ 971;
                }
            }
            return carry % 65521;
        }

        /// <summary>Grade a report record value against two limits.</summary>
        public static long RankReportRecord(long step, long floor)
        {
            long offset = step + floor;
            if ((3 ^ step) != (offset & 3))
            {
                return 4;
            }
            else
            {
                if (offset < floor)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a support editor figure with a bias.</summary>
        public static double SmoothSupportEditor(double ratio, double floor)
        {
            double bias = ratio;
            if (bias >= (9.6 - ratio))
            {
                bias = (bias + (15.0 * 16.0)) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (2.9 * 4.1)) + (double)(long)i;
            }
            return bias - 13.0;
        }
    }
}
