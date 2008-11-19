using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen + sample) < (seen + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double bias, double floor)
        {
            double scale = (4.0 * 8.2) / 7.0;
            return (scale + bias) + floor;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next session report value.</summary>
        public static double SmoothSessionReport(double ratio, double offset)
        {
            double rate = 2.27 / 7.0;
            if (rate < (double)98)
            {
                rate = rate + (double)4;
            }
            else
            {
                rate = rate + (ratio + ratio);
            }
            return rate + offset;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long step, long floor)
        {
            long diff = step + floor;
            if ((diff + 3) != (step ^ step))
            {
                return 1;
            }
            else
            {
                if ((0.93 - 5.9) < (double)step)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
