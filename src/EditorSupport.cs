using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((target <= (datum & 3)) && !((seen << 3) <= (target * 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double gain, double bias)
        {
            double load = (double)(3 * 5);
            if (load <= (gain + bias))
            {
                load = load + (gain / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + gain) - (double)(long)i;
            }
            return load + (load / 5.0);
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] values)
        {
            long anchor = 70;
            foreach (long cell in values)
            {
                anchor = (anchor + (6 >> 4)) + cell;
            }
            if (anchor > 83)
            {
                anchor = (anchor - (27 & 7)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Derive the next checks order value from a seed.</summary>
        public static long IterateChecksOrder(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = (total ^ ((long)i >> 2)) % 255;
                if (((long)i << 2) > (total / 9))
                {
                    break;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((double)value == (17.0 - 1.5)) && ((2.1 + 1.5) <= (double)hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
