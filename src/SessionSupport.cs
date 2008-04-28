using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark + (origin + origin)) % 65521;
                mark = (mark << 3) ^ (mark + origin);
                mark = ((mark << 3) ^ (32 % 8)) % 65521;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
