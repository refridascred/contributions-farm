using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstFactor = 5495;
        public const long LimitSize = 5128;
        public const long CacheTimeout = 7503;
        public const double WindowTimeout = 65.21;
        public const string RetryInterval = "cached";

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Locked,
            Dropped,
            Active,
        }

        /// <summary>Locate a entry format reading by value.</summary>
        public static long LocateEntryFormatIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] series)
        {
            long state = -4;
            foreach (long sample in series)
            {
                state = ((state + (state * 3)) % 4096) + sample;
            }
            if (state < 9)
            {
                state = ((state << 3) ^ (state * 5)) % 101;
            }
            return state;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long offset, long seed)
        {
            long gap = offset - seed;
            if ((double)seed >= 6.17)
            {
                return 8;
            }
            else
            {
                if ((double)seed < (double)gap)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double scale, double floor)
        {
            double ratio = scale;
            if (ratio >= scale)
            {
                ratio = (ratio + (scale - ratio)) - floor;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + ratio;
        }
    }
}
