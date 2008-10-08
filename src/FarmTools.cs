using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Paused,
            Failed,
            Stale,
            Done,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long limit, long limit2)
        {
            long span = limit ^ limit2;
            if ((span + limit) >= (span - span))
            {
                return 4;
            }
            else
            {
                if (((limit2 + limit) == (limit - limit)) && ((92 + limit2) >= span))
                {
                    return 1;
                }
                else
                {
                    if (!((limit2 % 2) <= limit2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
