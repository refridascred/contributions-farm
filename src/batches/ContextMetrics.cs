using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            Ready,
            Retry,
            Draft,
            Queued,
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double weight, double floor)
        {
            double ratio = (double)(468 + 164);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + 10.0) + (double)(long)i) - weight;
            }
            return ratio + (floor / 3.0);
        }
    }
}
