using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Draft,
            New,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Ready,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Iterate the window counter series from a seed.</summary>
        public static long RollWindowCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                if ((target + target) >= 51)
                {
                    score = (score << 3) ^ (441 & 63);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the counter cluster entries that pass the check.</summary>
        public static long TallyCounterClusterGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches % 24) < (72 + sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
