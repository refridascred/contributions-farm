using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(cell >= (seed << 2)))
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

        /// <summary>Project the next farm checks value.</summary>
        public static double ProjectFarmChecks(double weight, double offset)
        {
            double load = 7.55 / 9.0;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + offset) - (double)(long)i) - weight;
            }
            return load - load;
        }
    }
}
