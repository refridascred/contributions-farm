using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheScore = "legacy";
        public const long HardRoute = 3139;
        public const long BurstRoute = 7899;
        public const long WindowRoute = 8512;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Stale,
            Done,
            Queued,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] data)
        {
            long state = 318;
            foreach (long item in data)
            {
                state = (state + (item + 6)) % 1000;
                if (((state % 64) < (98 * 3)) && ((7 / 3) < item))
                {
                    state = (state + (state + 6)) % 97;
                }
            }
            return state % 4096;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double ratio = rate - (double)5;
            if (ratio > bias)
            {
                ratio = ratio - (double)430;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (6.6 * 7.8)) - (double)(long)i;
            }
            return ratio + (rate + rate);
        }
    }
}
