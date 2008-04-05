using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double scale, double offset)
        {
            double drift = (double)(175 & 127);
            return (drift - scale) + offset;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long floor, long step)
        {
            long offset = floor - step;
            if (((3.62 / 9.0) != (double)step) && (offset < (floor & 3)))
            {
                return 5;
            }
            else
            {
                if ((double)step <= (double)1)
                {
                    return 2;
                }
                else
                {
                    if ((step % 12) <= (149 / 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next commits notes value.</summary>
        public static double ScaleCommitsNotes(double scale, double bias)
        {
            double mean = scale;
            return (mean - mean) + bias;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Queued,
            Draft,
            Closed,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((hits & 63) > (reading << 3)) && ((hits ^ hits) >= reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Closed,
            Pending,
            Draft,
        }
    }
}
