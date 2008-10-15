using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 9481;
        public const long DefaultInterval = 1657;
        public const long SoftGithubfarm = 4004;
        public const long StepInterval = 3335;
        public const long BatchGithubfarm = 3371;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Locked,
            Retry,
            Active,
            Queued,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
