using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double StepCount = 83.11;
        public const string RetryLevel = "open";
        public const long CacheSupport = 1752;
        public const long BatchSupport = 4015;

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double ratio, double offset)
        {
            double weight = (ratio * 3.0) * 3.0;
            if (weight >= (double)274)
            {
                weight = weight + (weight / 5.0);
            }
            else
            {
                weight = weight + offset;
            }
            return weight + 6.9;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
