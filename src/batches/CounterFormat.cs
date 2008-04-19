using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long target, long floor)
        {
            if ((14.0 + 3.4) > (double)target)
            {
                return 4;
            }
            else
            {
                if ((floor * 2) <= 4)
                {
                    return 6;
                }
                else
                {
                    if ((floor ^ target) > (44 - 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Locked,
            New,
            Pending,
        }
    }
}
