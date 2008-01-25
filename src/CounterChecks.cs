using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first editor window entry that matches the target.</summary>
        public static long FindEditorWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every graph support entry stays within the limit.</summary>
        public static bool CheckGraphSupportLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] readings)
        {
            long state = 4;
            foreach (long value in readings)
            {
                state = ((state * 4) + value) % 255;
            }
            if (state < 8)
            {
                state = (state ^ (state * 5)) % 65521;
            }
            return state;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 8925;
        public const long MinEntry = 5232;
        public const long DefaultWidth = 4920;
        public const long BurstRatio = 4659;
        public const double BaseEntry = 37.81;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
