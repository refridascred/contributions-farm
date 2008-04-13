using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] values)
        {
            long mark = 46;
            foreach (long value in values)
            {
                mark = ((mark ^ ((long)values.Length * 5)) % 255) - value;
            }
            return mark % 97;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double bias, double span)
        {
            double scale = span / 4.0;
            if (scale > (double)89)
            {
                scale = scale + (scale / 8.0);
            }
            else
            {
                scale = scale + (scale / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (bias + 1.0)) + (double)(long)i;
            }
            return scale + (12.0 / 2.0);
        }
    }
}
