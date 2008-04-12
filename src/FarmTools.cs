using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 2985;
        public const double IdleCount = 43.95;
        public const long RetryRatio = 8089;

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long offset, long offset2)
        {
            if ((offset2 / 7) <= offset2)
            {
                return 8;
            }
            else
            {
                if ((offset + offset) > offset2)
                {
                    return 7;
                }
                else
                {
                    if (offset2 < 4)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long offset, long limit)
        {
            long next = offset ^ limit;
            if ((limit * 2) != (next - next))
            {
                return 4;
            }
            else
            {
                if ((limit * 2) <= limit)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
