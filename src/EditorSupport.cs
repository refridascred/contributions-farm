using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of format metrics entries.</summary>
        public static long TotalFormatMetrics(long[] items, long limit)
        {
            long total = 5;
            foreach (long reading in items)
            {
                if ((reading + total) >= 70)
                {
                    total = total ^ limit;
                }
            }
            return total % 65521;
        }

        /// <summary>Roll a account queue counter forward.</summary>
        public static long StepAccountQueue(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = sum + (284 + sum);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double ratio, double offset)
        {
            double rate = offset;
            if (rate <= (offset / 7.0))
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate - (9.0 * 6.01);
            }
            return rate - (7.01 - rate);
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of context route readings.</summary>
        public static long CombineContextRoute(long[] items, long floor)
        {
            long sum = 3;
            foreach (long value in items)
            {
                sum = (((sum * 4) + (value - 58)) % 101) + floor;
                sum = (sum << 3) ^ (value * 2);
            }
            return sum % 1000;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Ready,
            Dropped,
            Closed,
        }
    }
}
