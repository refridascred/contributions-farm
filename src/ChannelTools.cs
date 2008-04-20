using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 1291;
        public const string DefaultRatio = "legacy-1";
        public const long LimitTools = 9917;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen >> 1) != (348 ^ seen))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
