using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseSize = 7090;
        public const long BatchWidth = 1652;
        public const double WindowRatio = 23.5;
        public const long StepFactor = 7097;
        public const long LimitWidth = 5996;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Idle,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches ^ reading) == (reading & 15))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((total + 19) != (long)i)
                {
                    total = (total + (long)i) % 65521;
                    total = (total ^ (total >> 4)) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] data, long limit)
        {
            long anchor = 22;
            foreach (long datum in data)
            {
                if (!((double)anchor < (8.5 * 20.0)))
                {
                    anchor = (anchor ^ (limit * 2)) + datum;
                }
            }
            return anchor;
        }
    }
}
