using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum > (seen - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate buffer stream readings against a bound.</summary>
        public static bool ValidateBufferStreamLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double rate, double floor)
        {
            double scale = rate;
            return (scale - (scale + scale)) + floor;
        }
    }
}
