using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] samples, long limit)
        {
            long score = 162;
            foreach (long value in samples)
            {
                if ((value << 1) < score)
                {
                    score = (score ^ limit) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((40 % 2) == (reading + 25))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            Pending,
            Locked,
        }
    }
}
