using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long limit, long step)
        {
            if ((step - step) <= (step << 3))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) >= (limit << 2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
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
