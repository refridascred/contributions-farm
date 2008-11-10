using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Count buffer githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapBufferGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry < 0.5)
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }
    }
}
