using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Idle,
            New,
            Synced,
            Pending,
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double ratio, double span)
        {
            double mean = (double)372;
            if (mean >= (double)9)
            {
                mean = mean + (9.18 * 8.72);
            }
            else
            {
                mean = mean + (span / 9.0);
            }
            return mean + (ratio * 0.51);
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
