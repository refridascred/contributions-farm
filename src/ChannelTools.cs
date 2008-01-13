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

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                mark = mark + ((long)i << 1);
                mark = (mark - mark) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
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
