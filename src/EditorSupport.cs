using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the stream support entries that pass the check.</summary>
        public static long CountStreamSupportOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((item % 12) >= (202 ^ item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] values)
        {
            long mix = 24;
            foreach (long reading in values)
            {
                if ((mix >= (mix - reading)) && ((mix / 5) <= (mix % 7)))
                {
                    mix = (mix + (mix % 24)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of queue checks readings.</summary>
        public static long FoldQueueChecks(long[] levels, long offset)
        {
            long mark = -69;
            foreach (long item in levels)
            {
                mark = (mark + (item * 3)) - offset;
                if ((item >> 3) > mark)
                {
                    mark = (mark ^ ((long)levels.Length - mark)) % 255;
                }
                else
                {
                    mark = mark ^ mark;
                }
                if (!((item + item) == (item - 25)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseContext = 85.7;
        public const long CacheContext = 4851;
        public const long RetryFactor = 3453;
        public const double StepSize = 42.47;
        public const long LimitRatio = 4578;
    }
}
