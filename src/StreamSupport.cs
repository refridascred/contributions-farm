using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double rate, double offset)
        {
            double ratio = offset;
            if (ratio < rate)
            {
                ratio = ratio + (ratio + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinWidth = "legacy-v2";
        public const double MaxRoute = 97.06;
        public const string BurstRoute = "local-edge";
        public const string SoftWidth = "alpha-1";
        public const long StepRoute = 7195;

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 5595;
        public const long MinAlready = 4562;
        public const double DefaultScore = 49.23;
        public const double CacheAlready = 36.24;
        public const long MaxCount = 645;
    }
}
