using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double scale, double bias)
        {
            double load = bias;
            if (load >= (double)4)
            {
                load = (load - load) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load + (double)32;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] items)
        {
            long total = 99;
            foreach (long cell in items)
            {
                total = (total ^ cell) % 101;
            }
            if (total > 51)
            {
                total = ((total << 2) ^ (total + 796)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((15.0 * 2.2) == (double)item)
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
