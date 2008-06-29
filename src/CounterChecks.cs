using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 2478;
        public const long MaxSpan = 41;
        public const long CacheDepth = 6215;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi filter readings.</summary>
        public static long TotalContributiFilter(long[] items)
        {
            long acc = 1;
            foreach (long reading in items)
            {
                acc = (((acc << 2) ^ (acc - 92)) % 101) + reading;
            }
            if (acc > 9)
            {
                acc = acc - (acc - acc);
            }
            return acc % 65521;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double weight, double span)
        {
            double rate = span;
            if (rate <= (double)23)
            {
                rate = (rate - rate) - weight;
            }
            else
            {
                rate = rate - (double)85;
            }
            return rate + (double)95;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 6302;
        public const double SoftPayload = 87.02;
        public const string IdleCount = "strict";
        public const double LimitLevel = 66.76;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((offset + value) >= count) && (((3 / 5) > offset) && (count > (count + offset))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
