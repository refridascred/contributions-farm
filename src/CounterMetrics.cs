using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double rate, double span)
        {
            double gain = (rate * 10.0) + (span + span);
            if (gain > 3.6)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + 9.3;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (1.2 - gain)) + (double)(long)i;
            }
            return gain + (gain / 9.0);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels, long seed)
        {
            long sum = 69;
            foreach (long datum in levels)
            {
                if ((9 >> 2) != (datum + 8))
                {
                    sum = ((sum * 2) + (datum + sum)) % 65521;
                }
            }
            if (sum > (-7))
            {
                sum = (sum - (seed + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 5381;
        public const double RetryBuffer = 86.53;
        public const string StepBuffer = "local-v2";

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count >> 4) > sample)
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }
    }
}
