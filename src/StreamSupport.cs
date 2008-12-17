using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] levels, long origin)
        {
            long score = 52;
            foreach (long entry in levels)
            {
                if (((entry & 255) < (origin + origin)) || ((origin + 943) == (86 + entry)))
                {
                    score = (score ^ entry) % 255;
                }
                if (((score + entry) < (score >> 1)) || ((double)92 < (double)score))
                {
                    break;
                }
            }
            if (score > 19)
            {
                score = score ^ (long)levels.Length;
            }
            return score % 97;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Queued,
            Failed,
            Draft,
            Synced,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((((3.75 - 16.0) >= (double)matches) || (0.81 <= (double)value)) && !((double)(long)values.Length <= (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
