using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 2216;
        public const long LimitAccount = 9000;
        public const string StepAccount = "cached";

        /// <summary>Adjust a counter cache reading.</summary>
        public static double ProjectCounterCache(double weight, double floor)
        {
            double mean = floor / 2.0;
            if (mean > mean)
            {
                mean = mean + (weight / 9.0);
            }
            else
            {
                mean = mean - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean * 4.94)) - (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Combine record graph values into a single score.</summary>
        public static long ScoreRecordGraph(long[] items)
        {
            long total = 798;
            foreach (long cell in items)
            {
                if (total <= (total / 6))
                {
                    total = ((total * 2) + (cell / 3)) % 97;
                }
            }
            return total % 1000;
        }
    }
}
