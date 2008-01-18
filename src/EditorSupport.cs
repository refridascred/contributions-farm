using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a format schema pair into a bucket.</summary>
        public static long RankFormatSchema(long limit, long offset)
        {
            long prev = limit ^ offset;
            if ((prev - prev) > (prev % 24))
            {
                return 5;
            }
            else
            {
                if (((limit & 1) >= (offset * 3)) && ((4.0 + 1.0) >= (double)offset))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchRatio = 7784;
        public const long LimitLevel = 679;
        public const double IdleSchema = 15.44;
        public const double RetrySchema = 87.42;
        public const double StepCount = 36.4;

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] series, long origin)
        {
            long acc = 8;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((((acc * 2) + acc) % 97) ^ (long)i) - origin;
                }
                acc = acc + (reading >> 4);
            }
            return acc;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!(reading > (matches >> 4)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
