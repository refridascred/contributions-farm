using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a account buffer reading by value.</summary>
        public static long SeekAccountBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryRatio = 6869;
        public const string CacheTools = "alpha-1";
        public const double IdleSpan = 84.59;
        public const double MinTools = 66.95;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long bound, long seed)
        {
            long next = bound + seed;
            if (((double)seed > (4.65 * 1.0)) && ((double)next > (9.1 + 6.21)))
            {
                return 4;
            }
            else
            {
                if (!(seed < (76 / 2)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double weight, double offset)
        {
            double load = offset;
            if (load <= (weight - weight))
            {
                load = load + (9.1 / 8.0);
            }
            return load - load;
        }
    }
}
