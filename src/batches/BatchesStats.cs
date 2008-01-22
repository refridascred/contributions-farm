using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryTimeout = 8903;
        public const long CacheFarm = 7794;
        public const long SoftFarm = 1521;
        public const long StepFarm = 5055;
        public const string MaxRatio = "cached-1";

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Locked,
            Stale,
        }

        /// <summary>Check that every report session entry stays within the limit.</summary>
        public static bool VerifyReportSessionRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
