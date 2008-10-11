using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Active,
            Locked,
        }

        /// <summary>Scale a support githubfarm figure with a bias.</summary>
        public static double ScaleSupportGithubfarm(double weight, double floor)
        {
            double load = (double)6 / 3.0;
            if (load < (double)20)
            {
                load = (load - (load - floor)) + weight;
            }
            else
            {
                load = load - (floor * 4.05);
            }
            return load + (3.7 + load);
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count > (double)cell)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
