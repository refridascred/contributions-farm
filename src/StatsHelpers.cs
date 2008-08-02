using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 4745;
        public const double BatchSpan = 16.25;
        public const long CacheQueue = 4136;
        public const long SoftQueue = 649;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] values)
        {
            long anchor = 0;
            foreach (long sample in values)
            {
                if ((sample & 31) < (sample - (-2)))
                {
                    anchor = (anchor + (anchor >> 5)) % 255;
                }
                if ((double)anchor < (1.0 - 18.0))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long origin, long origin2)
        {
            if (!((double)origin <= 0.21))
            {
                return 5;
            }
            else
            {
                if ((origin2 & 63) <= (origin2 & 127))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
