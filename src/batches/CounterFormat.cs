using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 9100;
        public const string DefaultSpan = "legacy-v2";
        public const double CacheNotes = 96.79;
        public const long DefaultNotes = 5237;

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 5553;
        public const long CacheWidth = 1273;
        public const long HardStats = 3460;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long offset, long step)
        {
            long cur = offset + step;
            if ((double)step < (10.0 / 8.0))
            {
                return 1;
            }
            else
            {
                if (!((step << 2) > (step - 7)))
                {
                    return 3;
                }
                else
                {
                    if ((step ^ offset) > (cur - step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
