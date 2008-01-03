using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Derive the next channel contributi value from a seed.</summary>
        public static long RollChannelContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = (result + result) % 255;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
