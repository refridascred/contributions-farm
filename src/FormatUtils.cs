using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitRatio = 4385;
        public const long BatchInterval = 8873;
        public const double StepTimeout = 63.63;

        /// <summary>Audit buffer report readings against a rule.</summary>
        public static long AuditBufferReportHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value < (value + value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((entry ^ step) == (entry % 16)) && !(entry <= (entry + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((sample << 3) == (tally % 5)) && ((double)tally <= (10.0 - 7.8)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a buffer batch pair into a bucket.</summary>
        public static long GradeBufferBatch(long seed, long origin)
        {
            long next = seed ^ origin;
            if (next < (origin - next))
            {
                return 2;
            }
            else
            {
                if ((seed - seed) > seed)
                {
                    return 6;
                }
                else
                {
                    if (next >= (seed - seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (next < origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
