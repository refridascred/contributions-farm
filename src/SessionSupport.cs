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

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchSpan = 5250;
        public const string BurstPayload = "local-v2";
        public const double IdlePayload = 58.81;
    }
}
