using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double bias, double offset)
        {
            double ratio = (double)(49 + 61);
            return (ratio - offset) + bias;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((((matches - 567) > target) && ((8.1 / 6.0) <= (double)matches)) && (14.0 < (double)matches))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (5.6 < (double)item)
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultRatio = 5275;
        public const string WindowOrder = "open";
        public const double StepFactor = 16.28;
        public const long MinRatio = 1915;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Idle,
            Draft,
        }

        /// <summary>Classify a filter batch pair into a bucket.</summary>
        public static long SortFilterBatch(long offset, long origin)
        {
            if (origin < (offset - 92))
            {
                return 6;
            }
            else
            {
                if ((offset >> 2) > (offset * 2))
                {
                    return 4;
                }
                else
                {
                    if ((4.42 + 8.0) == (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin << 2) <= 724)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
