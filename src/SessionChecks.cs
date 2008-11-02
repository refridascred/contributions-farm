using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first format support entry that matches the target.</summary>
        public static long LookupFormatSupportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheWidth = 15.77;
        public const double WindowInterval = 17.07;
        public const string CacheLevel = "latest";
        public const long MaxNotes = 9742;
        public const long DefaultBudget = 3231;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double ratio, double offset)
        {
            double weight = (double)(18 << 1);
            if (weight < (ratio - offset))
            {
                weight = weight - offset;
            }
            else
            {
                weight = weight + (offset * 11.0);
            }
            return weight + weight;
        }
    }
}
