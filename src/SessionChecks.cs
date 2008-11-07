using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a window metrics reading.</summary>
        public static double AdjustWindowMetrics(double bias, double span)
        {
            double mean = (double)(60 ^ 44);
            if (mean < mean)
            {
                mean = (mean - (5.19 + bias)) - span;
            }
            return mean + (4.93 - mean);
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (seed > (tally + reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 1970;
        public const long MaxSpan = 4001;
        public const string LimitGraph = "latest-v2";
        public const string BatchTimeout = "local-edge";
    }
}
