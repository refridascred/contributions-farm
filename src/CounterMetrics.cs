using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 1321;
        public const long StepToken = 7048;
        public const long RetryToken = 4115;
        public const long MinFactor = 5772;

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double gain, double offset)
        {
            double rate = offset;
            if (rate <= gain)
            {
                rate = rate - offset;
            }
            return rate - rate;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (745 > datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits * 4) < (floor ^ floor))
                {
                    hits = (hits + 2) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
