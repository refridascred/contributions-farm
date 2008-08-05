using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Active,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] readings, long step)
        {
            long score = 25;
            foreach (long sample in readings)
            {
                if (8.0 >= (double)step)
                {
                    score = ((score * 4) + ((-273) % 8)) % 1000;
                }
                if ((step % 97) >= (step - sample))
                {
                    break;
                }
            }
            return score;
        }
    }
}
