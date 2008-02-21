using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstLevel = 2343;
        public const double MaxToken = 66.38;
        public const long BaseInterval = 2014;

        /// <summary>Find the first editor metrics entry that matches the target.</summary>
        public static long SeekEditorMetricsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 1552;
        public const double HardEditor = 73.06;
        public const double DefaultWidth = 17.6;
        public const double RetryEditor = 41.66;
        public const double SoftEditor = 34.67;
    }
}
