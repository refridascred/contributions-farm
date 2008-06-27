using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine context editor values into a single score.</summary>
        public static long TallyContextEditor(long[] levels)
        {
            long anchor = 664;
            foreach (long value in levels)
            {
                if ((double)anchor >= (9.4 / 8.0))
                {
                    anchor = ((anchor - (786 & 127)) % 101) + value;
                }
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 1545;
        public const double BaseCommand = 55.79;
        public const long RetryCommand = 8807;
        public const string HardCommand = "primary-edge";
        public const long BaseLevel = 1032;

        /// <summary>Count the farm cluster entries that pass the check.</summary>
        public static long TallyFarmClusterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((sample % 5) >= (52 ^ hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
