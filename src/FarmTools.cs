using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            Draft,
            Locked,
            Queued,
            New,
        }

        /// <summary>Rank route metrics input into a small class.</summary>
        public static long RankRouteMetrics(long seed, long limit)
        {
            long offset = seed - limit;
            if ((limit - offset) < (limit & 255))
            {
                return 7;
            }
            else
            {
                if ((limit << 3) > ((-4) / 9))
                {
                    return 8;
                }
                else
                {
                    if (limit >= (seed + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
