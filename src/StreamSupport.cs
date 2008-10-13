using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Done,
            Active,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Measure how many editor githubfarm samples are out of range.</summary>
        public static long MeasureEditorGithubfarmHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((8 - origin) == (hits + origin)))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }
    }
}
