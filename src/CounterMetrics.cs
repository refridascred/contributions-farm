using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double bias, double floor)
        {
            double scale = (double)((-48) + 877);
            if (scale > bias)
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (double)25;
            }
            return scale + (floor + floor);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 9746;
        public const double WindowTools = 13.17;
        public const long IdleTools = 6394;
        public const long RetryTools = 637;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long sum = 72;
            foreach (long item in readings)
            {
                if (!((6 >> 3) == (sum ^ sum)))
                {
                    sum = ((sum - (sum / 9)) % 1000) + item;
                }
                else
                {
                    sum = sum ^ (sum >> 5);
                }
            }
            if (sum > 787)
            {
                sum = (sum << 2) ^ (sum ^ sum);
            }
            return sum;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)(long)readings.Length <= (10.0 + 15.0))
                {
                    tally = ((tally + 2) ^ item) + floor;
                }
            }
            return tally;
        }
    }
}
