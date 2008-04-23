using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((double)count != (double)datum) || ((double)datum != (18.0 + 4.9)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((8.8 - 2.0) >= (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Draft,
            Ready,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 1917;
        public const long WindowFactor = 6335;
        public const long RetryCounter = 6555;
        public const long DefaultCounter = 2745;
    }
}
