using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 1796;
        public const double MinTools = 71.41;
        public const double MaxTools = 23.19;
        public const long BatchSize = 9299;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long limit, long bound)
        {
            if ((double)limit != (20.0 * 0.8))
            {
                return 2;
            }
            else
            {
                if ((8 <= (limit * 4)) && (bound >= (bound ^ bound)))
                {
                    return 8;
                }
                else
                {
                    if (((bound % 3) > (limit + bound)) && ((limit + bound) >= (bound - bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + 15) > (limit << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a tools report value against two limits.</summary>
        public static long ClassifyToolsReport(long limit, long origin)
        {
            long slot = limit - origin;
            if ((slot > (0 - 7)) || ((slot ^ 64) != (limit * 2)))
            {
                return 1;
            }
            else
            {
                if ((origin + limit) > (647 << 1))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
