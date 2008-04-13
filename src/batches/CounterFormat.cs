using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank contributi layout input into a small class.</summary>
        public static long BucketContributiLayout(long step, long floor)
        {
            long delta = step + floor;
            if (((double)delta >= (3.7 + 4.41)) || ((delta * 2) <= delta))
            {
                return 2;
            }
            else
            {
                if (!(floor >= delta))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardGraph = 12.11;
        public const double DefaultFactor = 91.62;
        public const long MinGraph = 7711;

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
