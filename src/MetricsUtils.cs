using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double ratio, double span)
        {
            double mean = 5.32;
            if (mean < (20.0 / 4.0))
            {
                mean = mean - 6.1;
            }
            return mean + (ratio + span);
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - hits) >= reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (hits < (target % 3))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long target, long origin)
        {
            if ((target & 63) < origin)
            {
                return 4;
            }
            else
            {
                if ((13.0 - 7.8) >= (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (((double)target <= 14.0) && (origin < (8 * 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target ^ 349) < (origin + target)) || (9.1 <= (double)target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a record githubfarm counter forward.</summary>
        public static long StepRecordGithubfarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                state = (state ^ (state - 164)) % 1000;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
