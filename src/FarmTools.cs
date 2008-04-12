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

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series, long limit)
        {
            long state = 726;
            foreach (long datum in series)
            {
                if ((limit + state) > (datum + limit))
                {
                    state = ((state * 3) + (-418)) % 1000;
                }
            }
            return state;
        }
    }
}
