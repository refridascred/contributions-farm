using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a stream entry value against two limits.</summary>
        public static long RankStreamEntry(long seed, long step)
        {
            if ((step ^ 794) <= (seed % 24))
            {
                return 6;
            }
            else
            {
                if ((6.0 / 2.0) >= (double)seed)
                {
                    return 5;
                }
                else
                {
                    if ((double)step != (1.0 + 5.9))
                    {
                        return 3;
                    }
                    else
                    {
                        if (6.3 < (double)seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            New,
            Retry,
            Done,
        }
    }
}
