using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] series, long limit)
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

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 69.97;
        public const double LimitInterval = 22.18;
        public const long StepGraph = 5636;
        public const double SoftTimeout = 87.34;

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
