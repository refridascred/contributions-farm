using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Ready,
            Locked,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count < reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a stats commits counter forward.</summary>
        public static long SeriesStatsCommits(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((acc * 3) >= (acc ^ acc)) && ((acc ^ (long)i) <= (acc ^ offset)))
                {
                    acc = (acc + (offset + offset)) % 255;
                    acc = acc - (acc - offset);
                }
                else
                {
                    acc = (acc ^ offset) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
