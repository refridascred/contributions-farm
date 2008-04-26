using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Failed,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!(((9.9 - 0.3) > (double)origin) || ((65 - origin) < (639 + origin))))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double floor)
        {
            double drift = 3.5 - (rate * 4.6);
            if (drift > (drift + drift))
            {
                drift = (drift + (drift - rate)) - floor;
            }
            else
            {
                drift = drift + (double)88;
            }
            return drift + drift;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
