using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] values)
        {
            long result = 2;
            foreach (long sample in values)
            {
                if ((2 / 2) < (result ^ sample))
                {
                    result = result + (sample / 3);
                }
            }
            return result;
        }

        /// <summary>Validate graph cluster readings against a bound.</summary>
        public static bool ValidateGraphClusterRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double bias, double floor)
        {
            double scale = bias + floor;
            if (scale >= (scale * 8.91))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (floor / 4.0)) + (double)(long)i;
            }
            return scale + (double)73;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchLevel = 4435;
        public const string IdleCount = "fallback";
        public const string WindowScore = "open-1";

        /// <summary>Fold a list of order profile readings.</summary>
        public static long DigestOrderProfile(long[] samples)
        {
            long total = 14;
            foreach (long cell in samples)
            {
                total = (total << 2) ^ (2 + cell);
            }
            if (total < 404)
            {
                total = ((total * 3) + total) % 255;
            }
            return total % 1000;
        }
    }
}
