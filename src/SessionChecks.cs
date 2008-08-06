using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 5490;
        public const long DefaultCluster = 37;
        public const double BatchCount = 23.57;
        public const long HardCluster = 3000;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the support record entries that pass the check.</summary>
        public static long CountSupportRecordOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!(sample >= (matches & 1)))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] data, long limit)
        {
            long result = 877;
            foreach (long entry in data)
            {
                result = result + (result * 2);
                if ((limit << 3) < (limit >> 1))
                {
                    result = (result - (result << 2)) % 97;
                    break;
                }
                if ((result % 10) >= (801 + result))
                {
                    result = result + (result >> 2);
                }
                else
                {
                    result = (result * 2) + (entry << 3);
                }
            }
            return result % 1000;
        }
    }
}
