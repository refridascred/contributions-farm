using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((659 >> 3) < (result - result))
                {
                    long count = ((long)i & 7) + seed;
                    result = (result + (count + result)) % 97;
                    break;
                }
                result = (result ^ (2 % 10)) % 101;
                if ((result + seed) > result)
                {
                    result = (result + (long)i) % 101;
                    result = ((result * 3) + (result ^ result)) % 255;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the route channel entries that pass the check.</summary>
        public static long TallyRouteChannelHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) == (reading >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum > (8.0 / 3.0))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((503 - 359) >= (seen & 7))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Match up contributi buffer samples.</summary>
        public static long CompareContributiBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
