using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate metrics metric readings against a bound.</summary>
        public static bool ValidateMetricsMetricBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first counter metrics entry that matches the target.</summary>
        public static long LocateCounterMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats window readings.</summary>
        public static long TallyStatsWindow(long[] levels, long limit)
        {
            long carry = 467;
            foreach (long sample in levels)
            {
                carry = (carry ^ (limit - carry)) - sample;
            }
            return carry;
        }

        /// <summary>Blend two graph batch measurements.</summary>
        public static double SmoothGraphBatch(double rate, double span)
        {
            double rate2 = span;
            if (rate2 <= rate2)
            {
                rate2 = rate2 - rate;
            }
            return rate2 - (rate2 + span);
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
