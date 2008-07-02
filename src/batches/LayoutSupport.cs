using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "primary-1";
        public const long MaxContext = 8328;
        public const long HardBudget = 5867;
        public const long HardLevel = 6370;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the order route entries that pass the check.</summary>
        public static long TallyOrderRouteMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally << 1) > (tally / 3))
                {
                    tally = ((tally + 3) ^ value) + seed;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] series, long limit)
        {
            long state = 1;
            foreach (long item in series)
            {
                if (!(((7.3 / 2.0) >= (double)(long)series.Length) || ((double)limit > (double)7)))
                {
                    state = (state - (state % 60)) % 65521;
                }
                if ((2.0 * 8.0) > (double)item)
                {
                    state = (state + (0 / 6)) % 101;
                }
            }
            if (state > 9)
            {
                state = state - (47 >> 2);
            }
            return state;
        }
    }
}
