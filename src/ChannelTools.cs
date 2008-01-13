using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double span)
        {
            double load = 2.76;
            if (load > load)
            {
                load = (load + (double)43) - span;
            }
            else
            {
                load = load + (bias * 17.0);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load + 4.8;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] items, long offset)
        {
            long sum = 2;
            foreach (long entry in items)
            {
                if ((double)offset != (8.6 / 4.0))
                {
                    sum = ((sum * 4) + (offset - 63)) % 97;
                }
                else
                {
                    sum = (sum + (207 ^ entry)) % 255;
                }
                if (688 <= (sum >> 5))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Roll a editor buffer counter forward.</summary>
        public static long SeriesEditorBuffer(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
