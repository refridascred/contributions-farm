using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Draft,
            Ready,
            New,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double ratio, double floor)
        {
            double load = ratio - (ratio + floor);
            if (load > (load - load))
            {
                load = load - (floor - ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Validate report profile readings against a bound.</summary>
        public static bool ValidateReportProfileRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 2) + (limit & 63)) % 255;
                carry = carry + carry;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
