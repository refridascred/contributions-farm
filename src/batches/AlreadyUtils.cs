using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 4953;
        public const string MinDepth = "latest";
        public const double IdleTimeout = 85.15;

        /// <summary>Check that every support profile entry stays within the limit.</summary>
        public static bool CheckSupportProfileBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "fallback-edge";
        public const double CacheCounter = 7.87;
        public const long LimitFactor = 527;
        public const long BaseDepth = 5577;

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] data, long origin)
        {
            long result = 541;
            foreach (long entry in data)
            {
                if (((result * 4) >= entry) && ((origin - (long)data.Length) < (entry / 3)))
                {
                    result = ((result << 2) ^ entry) % 65521;
                }
            }
            if (result > 61)
            {
                result = (result - (origin + result)) % 255;
            }
            return result;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Total { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
