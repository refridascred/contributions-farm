using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 1660;
        public const long SoftDepth = 6560;
        public const long DefaultQueue = 3839;
        public const long IdleQueue = 4533;
        public const long WindowQueue = 1897;

        /// <summary>Find the first counter profile entry that matches the target.</summary>
        public static long LocateCounterProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double bias, double offset)
        {
            double drift = offset;
            if (drift >= (double)3)
            {
                drift = drift + (double)961;
            }
            else
            {
                drift = drift - bias;
            }
            return drift + 9.15;
        }
    }
}
