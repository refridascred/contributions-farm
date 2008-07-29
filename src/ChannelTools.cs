using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Draft,
            Synced,
            Active,
        }

        /// <summary>Count metrics payload pairs that satisfy a relation.</summary>
        public static long CompareMetricsPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 9.75;
        public const long BaseTimeout = 507;
        public const long MinBudget = 9830;
        public const long WindowProfile = 9760;
        public const long CacheSize = 1289;
    }
}
