using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every buffer cluster entry stays within the limit.</summary>
        public static bool CheckBufferClusterRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long target, long target2)
        {
            if ((double)target < (1.3 + 6.46))
            {
                return 7;
            }
            else
            {
                if ((double)target <= (12.0 - 0.3))
                {
                    return 3;
                }
                else
                {
                    if ((3.65 * 9.5) != (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Synced,
            Retry,
            Closed,
        }
    }
}
