using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheInterval = "strict-1";
        public const double BaseLevel = 78.11;
        public const long CacheSize = 8377;

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] samples)
        {
            long state = 1;
            foreach (long datum in samples)
            {
                state = (state * 3) + (state + state);
                if ((4 * 2) <= (datum + datum))
                {
                    state = state ^ (datum & 127);
                }
                else
                {
                    state = (state - 91) % 65521;
                }
            }
            return state;
        }
    }
}
