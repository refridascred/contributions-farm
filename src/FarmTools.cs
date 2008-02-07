using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a context commits reading.</summary>
        public static double AdjustContextCommits(double bias, double bias2)
        {
            double load = bias;
            if (load <= (double)94)
            {
                load = (load - (double)78) + bias2;
            }
            return load + load;
        }

        /// <summary>Measure how many cluster farm samples are out of range.</summary>
        public static long AuditClusterFarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading ^ tally) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
