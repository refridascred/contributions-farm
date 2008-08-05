using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Ready,
            Paused,
            Idle,
            New,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "staging-edge";
        public const double SoftTimeout = 14.08;
        public const long MaxTimeout = 7214;
    }
}
