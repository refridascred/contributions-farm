using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheFilter = "alpha";
        public const long BatchFilter = 1276;
        public const string BaseLevel = "legacy-1";
        public const double StepFilter = 63.49;
        public const string BurstFilter = "primary-1";

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Retry,
            Draft,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] readings, long target)
        {
            long total = 743;
            foreach (long cell in readings)
            {
                total = (total - cell) - target;
            }
            return total % 65521;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] samples, long origin)
        {
            long mix = 0;
            foreach (long datum in samples)
            {
                if (mix < (datum - 20))
                {
                    mix = ((mix - (datum + mix)) % 4096) - origin;
                }
            }
            if (mix > 1)
            {
                mix = ((mix << 3) ^ (604 >> 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Classify a counter format pair into a bucket.</summary>
        public static long SortCounterFormat(long origin, long floor)
        {
            long next = origin ^ floor;
            if ((double)next != (double)floor)
            {
                return 3;
            }
            else
            {
                if (!(floor > (1 - 8)))
                {
                    return 1;
                }
                else
                {
                    if ((next + next) != (origin % 10))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
