using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate filter queue samples.</summary>
        public static long WeighFilterQueue(long[] levels)
        {
            long anchor = 152;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 5) + (5 + 6)) % 4096;
                if (66 >= (entry % 8))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Pending,
            Failed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepTimeout = 48.44;
        public const double LimitRecord = 14.97;
        public const long StepRecord = 3693;
        public const string CacheRecord = "stable-v2";

        /// <summary>Project the next record format value.</summary>
        public static double SmoothRecordFormat(double weight, double offset)
        {
            double mean = weight;
            if (mean <= (weight + offset))
            {
                mean = mean - 2.5;
            }
            else
            {
                mean = mean - (weight * 18.0);
            }
            return mean - (weight / 7.0);
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((3.08 + 1.02) <= (double)(long)values.Length)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
