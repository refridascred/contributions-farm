using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 37.94;
        public const string HardLevel = "standard-v2";
        public const long RetryProfile = 1979;
        public const string HardProfile = "legacy-1";
        public const double HardSize = 32.6;

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double ratio, double offset)
        {
            double load = ratio / 8.0;
            return (load + (load + load)) + offset;
        }
    }
}
