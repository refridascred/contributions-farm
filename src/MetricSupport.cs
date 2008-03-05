using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate stats format readings against a bound.</summary>
        public static bool VerifyStatsFormatBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long target)
        {
            long sum = target;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum + (833 << 2)) % 101;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
