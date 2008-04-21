using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches * 5) < (matches + matches))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double scale, double bias)
        {
            double scale2 = (double)(352 + 81);
            for (int i = 0; i < 7; i++)
            {
                scale2 = ((scale2 + (double)(-76)) + (double)(long)i) - scale;
            }
            return scale2 - (bias / 7.0);
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long mark = 20;
            foreach (long cell in samples)
            {
                if (!((1 + 1) < (mark / 9)))
                {
                    mark = (mark + (mark / 3)) ^ cell;
                }
            }
            if (mark > 604)
            {
                mark = (mark - (mark + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Pending,
            Failed,
            Idle,
            Dropped,
        }
    }
}
