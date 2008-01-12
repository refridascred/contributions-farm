using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchLevel = 9180;
        public const long IdleFactor = 6260;
        public const long HardCommits = 8082;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next channel notes value from a seed.</summary>
        public static long SeriesChannelNotes(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor + (offset + offset)) + (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a account checks value against two limits.</summary>
        public static long GradeAccountChecks(long offset, long limit)
        {
            long delta = offset + limit;
            if (!((delta % 12) != (delta / 3)))
            {
                return 4;
            }
            else
            {
                if ((offset % 24) == (offset - 502))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
