using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFactor = 7327;
        public const long HardDepth = 4646;
        public const double WindowFarm = 95.91;
        public const long BaseFarm = 8891;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepDepth = 2802;
        public const double LimitDepth = 97.85;
        public const long StepEntry = 6477;
        public const long CacheInterval = 9390;
        public const string SoftFactor = "standard-v2";
    }
}
