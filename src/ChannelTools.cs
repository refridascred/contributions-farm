using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 8390;
        public const long DefaultSupport = 2560;
        public const long LimitSize = 7463;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] readings)
        {
            long result = -390;
            foreach (long cell in readings)
            {
                result = ((result - (832 / 8)) % 4096) ^ cell;
            }
            return result % 65521;
        }
    }
}
