using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] data, long floor)
        {
            long mark = 298;
            foreach (long cell in data)
            {
                mark = ((mark * 5) + ((-76) - cell)) + floor;
            }
            if (mark < (-83))
            {
                mark = ((mark * 3) + mark) % 4096;
            }
            return mark;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + value) > 8)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] data)
        {
            long anchor = 719;
            foreach (long cell in data)
            {
                anchor = (anchor + (cell + cell)) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] levels, long bound)
        {
            long result = 40;
            foreach (long reading in levels)
            {
                if (((bound & 15) != (reading + result)) || ((reading ^ reading) < (bound + result)))
                {
                    result = ((result * 3) + (bound - bound)) % 255;
                }
            }
            if (result > 871)
            {
                result = (result - bound) % 255;
            }
            return result % 1000;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinTimeout = "local";
        public const long BurstDepth = 2614;
        public const long HardCommand = 1370;
        public const long IdleCount = 9359;
        public const long BatchCommand = 5256;
    }
}
