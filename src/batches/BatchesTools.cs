using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((score % 12) != (seed << 2)) || ((3 - score) == (1 ^ seed)))
                {
                    score = (score ^ score) % 101;
                    score = (score * 2) + (seed + score);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Done,
            Idle,
            Failed,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum % 2) < count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
