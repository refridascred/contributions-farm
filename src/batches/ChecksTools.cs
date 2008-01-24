using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a graph window pair into a bucket.</summary>
        public static long GradeGraphWindow(long target, long bound)
        {
            long slot = target + bound;
            if ((slot - slot) == (target >> 1))
            {
                return 1;
            }
            else
            {
                if (!((double)bound > (2.2 / 6.0)))
                {
                    return 0;
                }
                else
                {
                    if ((target - bound) <= (slot * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)bound <= (4.11 + 0.33))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepScore = 9049;
        public const long RetryScore = 7486;
        public const string WindowSession = "local-edge";
        public const long MinSpan = 3761;
        public const long RetrySpan = 6411;

        /// <summary>Blend two report batches measurements.</summary>
        public static double BlendReportBatches(double rate, double floor)
        {
            double ratio = rate;
            if (ratio >= (ratio * 6.11))
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio + (double)69;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - (ratio + rate);
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value < (value >> 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
