using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell >> 1) >= (seen - cell))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double bias, double offset)
        {
            double mean = (double)(323 + 5);
            if (mean >= 0.31)
            {
                mean = (mean - bias) - offset;
            }
            else
            {
                mean = mean - (mean - mean);
            }
            return mean - (double)27;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long bound, long target)
        {
            if (!((target >> 2) > bound))
            {
                return 5;
            }
            else
            {
                if (!(344 < (bound / 4)))
                {
                    return 6;
                }
                else
                {
                    if ((18.0 - 5.0) < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
