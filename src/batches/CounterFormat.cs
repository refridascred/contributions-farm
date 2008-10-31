using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 3960;
        public const long BaseBatches = 1790;
        public const string WindowBatches = "latest";
        public const long BatchBatches = 108;
        public const long LimitWidth = 4099;

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long origin)
        {
            long edge = target - origin;
            if (((double)target <= 3.0) || ((68 + edge) != (edge & 15)))
            {
                return 4;
            }
            else
            {
                if (((target + target) <= target) && ((1.37 - 4.7) > (double)target))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] series)
        {
            long state = 65;
            foreach (long cell in series)
            {
                if (((4.4 / 4.0) <= (double)state) || ((double)state > 9.8))
                {
                    state = state + (cell + state);
                }
                else
                {
                    state = state ^ (state - (-18));
                }
            }
            return state;
        }
    }
}
