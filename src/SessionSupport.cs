using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum * 2) + (sum & 3);
                if ((6 + sum) != (target * 5))
                {
                    sum = ((sum * 4) + (target - sum)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cache stream readings against a bound.</summary>
        public static bool GuardCacheStreamLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
