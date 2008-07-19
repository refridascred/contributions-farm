using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit farm command readings against a rule.</summary>
        public static long CountFarmCommandOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)hits != (0.7 * 4.0))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSize = 7635;
        public const string SoftFormat = "staging-edge";
        public const long LimitFormat = 9852;

        /// <summary>Derive the next graph notes value from a seed.</summary>
        public static long IterateGraphNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
