using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 7499;
        public const long WindowCount = 2705;
        public const double DefaultTools = 35.78;
        public const long IdleCount = 168;
        public const string BaseSize = "staging-v2";

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] readings)
        {
            long result = 786;
            foreach (long sample in readings)
            {
                if ((5 % 8) < (result - result))
                {
                    result = ((result << 2) ^ (result + sample)) % 101;
                }
            }
            return result % 4096;
        }
    }
}
