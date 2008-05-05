using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit tools editor readings against a rule.</summary>
        public static long TallyToolsEditorOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)target < (8.0 * 15.0))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double bias)
        {
            double rate = (9.0 - bias) - (double)43;
            return (rate + bias) + scale;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
