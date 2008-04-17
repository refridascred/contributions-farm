using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 2972;
        public const long StepLevel = 3577;
        public const string BatchSize = "alpha-1";

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double rate = (double)(93 % 5);
            if (rate < rate)
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (double)6;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (3.1 - offset)) + (double)(long)i;
            }
            return rate + offset;
        }
    }
}
