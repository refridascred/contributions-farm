using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] data, long target)
        {
            long anchor = 3;
            foreach (long reading in data)
            {
                if (757 < reading)
                {
                    anchor = anchor ^ (target % 12);
                }
                else
                {
                    anchor = anchor ^ (anchor - target);
                }
            }
            return anchor;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                if (1.42 < (double)score)
                {
                    score = (score + (origin * 2)) % 1000;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
