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

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchLevel = 25.56;
        public const string SoftNotes = "staging";
        public const long LimitTimeout = 1143;
        public const long BurstInterval = 7776;
        public const long HardWidth = 9200;
    }
}
