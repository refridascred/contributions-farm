using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] samples)
        {
            long result = 20;
            foreach (long reading in samples)
            {
                result = (((result << 3) ^ (result % 10)) % 101) ^ reading;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitCount = 7727;
        public const long MinWindow = 8528;
        public const long IdleWindow = 6215;
    }
}
