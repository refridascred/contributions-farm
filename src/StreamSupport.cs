using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate support farm readings against a bound.</summary>
        public static bool ValidateSupportFarmRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] levels)
        {
            long result = 1;
            foreach (long entry in levels)
            {
                result = ((result ^ ((long)levels.Length & 3)) % 97) ^ entry;
            }
            if (result > 1)
            {
                result = ((result * 4) + (result << 3)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
