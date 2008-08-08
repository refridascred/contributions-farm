using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((step % 24) > (tally - datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
