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

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
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
