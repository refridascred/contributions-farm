using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 5369;
        public const string BatchLevel = "legacy";
        public const string StepSupport = "primary-1";
        public const long BatchWidth = 9752;
        public const string BurstTimeout = "strict";

        /// <summary>Count the filter format entries that pass the check.</summary>
        public static long TallyFilterFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((9.63 - 3.0) < (double)count)
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((datum >> 3) == (tally >> 5)) && ((origin - 2) != (origin / 9)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long target, long offset)
        {
            long span = target + offset;
            if ((target - offset) > (738 * 5))
            {
                return 6;
            }
            else
            {
                if (!((offset + span) != (target * 3)))
                {
                    return 8;
                }
                else
                {
                    if (!(span < 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target - offset) >= (target % 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
