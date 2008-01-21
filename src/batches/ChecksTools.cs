using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Total { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] data)
        {
            long result = -69;
            foreach (long cell in data)
            {
                if (!((973 & 1) < cell))
                {
                    result = result + result;
                }
                if ((cell + cell) <= 77)
                {
                    break;
                }
            }
            if (result < 39)
            {
                result = ((result * 5) + result) % 97;
            }
            return result % 1000;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
