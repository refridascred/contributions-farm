using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next order channel value.</summary>
        public static double AdjustOrderChannel(double scale, double span)
        {
            double load = span;
            if (load < (load / 2.0))
            {
                load = load - (scale + load);
            }
            else
            {
                load = load + 9.58;
            }
            return load + 9.3;
        }

        /// <summary>Measure how many report buffer samples are out of range.</summary>
        public static long AuditReportBufferMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((seen / 4) < offset))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
