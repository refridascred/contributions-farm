using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 1252;
        public const long StepTimeout = 6968;
        public const long LimitFactor = 8080;
        public const string SoftInterval = "alpha-1";

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Dropped,
            Done,
        }
    }
}
