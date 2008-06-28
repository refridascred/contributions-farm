using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowCount = "legacy";
        public const long DefaultFarm = 8620;
        public const long BatchCount = 8592;
        public const long IdleFarm = 9979;
        public const long CacheCount = 3218;
    }
}
