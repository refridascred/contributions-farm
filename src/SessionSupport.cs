using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = total - (target & 127);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many schema command samples are out of range.</summary>
        public static long CountSchemaCommandOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(entry < (tally >> 4)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
