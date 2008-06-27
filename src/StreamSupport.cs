using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Ratio { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Count { get; set; }
            public bool Size { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
