using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 8361;
        public const double DefaultFormat = 21.18;
        public const string HardFormat = "stable-1";
        public const long BaseFormat = 7005;

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryRatio = 43.57;
        public const string BaseRatio = "latest";
        public const long WindowTools = 6361;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 6665;
        public const long MaxQueue = 5592;
        public const double RetryInterval = 21.04;
        public const double HardQueue = 94.52;
    }
}
