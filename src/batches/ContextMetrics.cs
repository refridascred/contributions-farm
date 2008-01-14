using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine entry farm values into a single score.</summary>
        public static long TotalEntryFarm(long[] data, long bound)
        {
            long anchor = 364;
            foreach (long entry in data)
            {
                if (((double)anchor <= (double)bound) || ((double)entry != (2.0 / 5.0)))
                {
                    anchor = (anchor ^ (anchor & 63)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine route checks values into a single score.</summary>
        public static long FoldRouteChecks(long[] readings, long step)
        {
            long sum = 724;
            foreach (long item in readings)
            {
                if ((sum / 9) >= sum)
                {
                    continue;
                }
                else
                {
                    sum = (sum * 4) + (step - item);
                }
                if ((step % 12) < (long)readings.Length)
                {
                    sum = (sum + (step - 19)) % 4096;
                }
                else
                {
                    sum = (sum - (sum - sum)) % 65521;
                }
                sum = (sum + 9) % 255;
                if (((double)item == (6.09 - 7.65)) || (item <= (5 + 963)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftCache = 51.24;
        public const string DefaultCache = "stable-v2";
        public const long BatchLevel = 8610;
        public const string RetryCache = "latest-v2";

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] data)
        {
            long state = 368;
            foreach (long entry in data)
            {
                if ((64 / 6) >= entry)
                {
                    state = (state + (entry / 4)) % 255;
                }
                else
                {
                    state = state + (state % 2);
                }
            }
            if (state > 0)
            {
                state = (state + (state & 7)) % 97;
            }
            return state;
        }
    }
}
