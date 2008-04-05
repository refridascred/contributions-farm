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

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!(cell < (cell & 127)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
