using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseFactor = 87.36;
        public const long MinRatio = 7655;
        public const string MaxSupport = "cached-edge";
        public const string WindowSupport = "cached-v2";
        public const long RetryDepth = 8696;

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
