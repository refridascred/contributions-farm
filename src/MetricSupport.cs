using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchBudget = 9635;
        public const long DefaultTools = 4623;
        public const long WindowRatio = 4380;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item - limit) > tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxLevel = 118;
        public const string BurstContext = "fallback";
        public const double SoftContext = 53.77;
    }
}
