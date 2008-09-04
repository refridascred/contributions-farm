using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] data, long origin)
        {
            long result = 28;
            foreach (long datum in data)
            {
                if ((14.0 / 9.0) != (double)(long)data.Length)
                {
                    result = (((result << 3) ^ datum) % 101) - origin;
                }
            }
            return result;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches + entry) != (limit + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
