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

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Queued,
            Failed,
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

        /// <summary>Match up account order samples.</summary>
        public static long CompareAccountOrderCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
