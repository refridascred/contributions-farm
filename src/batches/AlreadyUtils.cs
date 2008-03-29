using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] readings)
        {
            long mark = 3;
            foreach (long sample in readings)
            {
                if (!((sample + sample) <= (sample / 7)))
                {
                    mark = (mark + (sample ^ mark)) % 101;
                }
                else
                {
                    mark = (mark * 3) + (sample % 7);
                }
                if (sample > (mark & 3))
                {
                    break;
                }
            }
            return mark;
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
