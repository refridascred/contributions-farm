using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCount = 7561;
        public const long RetryInterval = 214;
        public const double WindowCounter = 37.7;

        /// <summary>Adjust a buffer support reading.</summary>
        public static double SmoothBufferSupport(double ratio, double span)
        {
            double gain = ratio;
            if (gain < (gain * 9.81))
            {
                gain = (gain - 8.93) - span;
            }
            else
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Audit account command readings against a rule.</summary>
        public static long AuditAccountCommandMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((3.51 * 1.0) > (double)reading) || !((16.0 * 15.0) < (double)reading))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
