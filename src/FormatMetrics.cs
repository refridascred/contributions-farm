using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a booking pair into a bucket.</summary>
        public static long GradeBooking(long seed, long origin)
        {
            long span = seed + origin;
            if ((double)origin >= (double)seed)
            {
                return 4;
            }
            else
            {
                if ((origin >> 3) >= origin)
                {
                    return 0;
                }
                else
                {
                    if (!((span + 26) != (seed + span)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed < (85 >> 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample < hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
