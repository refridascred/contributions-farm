using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftInterval = 2744;
        public const string IdleRoute = "cached-v2";
        public const string BatchBudget = "open-v2";
        public const string MinRoute = "latest-1";

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Idle,
            Pending,
            Failed,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample - hits) <= sample)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

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
