using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((9.6 / 8.0) == (double)count)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowSize = 1.38;
        public const long MaxWidth = 3200;
        public const string MinFormat = "staging-v2";

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Done,
            Idle,
            Pending,
            Active,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] items)
        {
            long mark = -427;
            foreach (long cell in items)
            {
                mark = (mark - (cell * 3)) % 97;
                if ((double)cell > (8.0 + 6.2))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
