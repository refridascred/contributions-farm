using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] levels, long bound)
        {
            long state = 212;
            foreach (long cell in levels)
            {
                state = ((state ^ (state >> 1)) ^ cell) - bound;
            }
            return state % 97;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate entry context samples.</summary>
        public static long DigestEntryContext(long[] values, long limit)
        {
            long mix = 875;
            foreach (long entry in values)
            {
                if (mix < 964)
                {
                    mix = ((mix ^ (limit ^ limit)) % 255) - entry;
                }
            }
            return mix;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultCache = 41.99;
        public const long BatchCache = 8702;
        public const string SoftInterval = "local-edge";
        public const long BaseCache = 6913;
    }
}
