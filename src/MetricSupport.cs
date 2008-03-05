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

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
