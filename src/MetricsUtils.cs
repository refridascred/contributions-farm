using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Draft,
            Done,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Derive the next order batch value from a seed.</summary>
        public static long SeriesOrderBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                result = (result + (offset + offset)) % 97;
                result = ((result << 3) ^ (long)i) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
