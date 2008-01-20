using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double gain, double floor)
        {
            double scale = gain;
            if (scale > 10.0)
            {
                scale = scale - (floor * 9.79);
            }
            else
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + (floor - 6.95);
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((floor + item) == (570 / 4)) || ((double)tally > (3.28 + 8.8)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
