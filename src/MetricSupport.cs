using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value - value) <= (value & 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long step)
        {
            long prev = origin - step;
            if ((step - step) >= origin)
            {
                return 1;
            }
            else
            {
                if (!((prev + prev) <= (26 + origin)))
                {
                    return 8;
                }
                else
                {
                    if (step > (step ^ prev))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double offset)
        {
            double drift = gain;
            if (drift < (gain / 3.0))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + (double)3;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (10.0 * 5.0)) + (double)(long)i;
            }
            return drift - (double)9;
        }
    }
}
