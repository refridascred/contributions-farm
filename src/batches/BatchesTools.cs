using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (value < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate route payload samples.</summary>
        public static long ScoreRoutePayload(long[] samples)
        {
            long anchor = 65;
            foreach (long sample in samples)
            {
                if ((anchor / 4) > anchor)
                {
                    anchor = ((anchor * 2) + (sample * 2)) % 101;
                }
            }
            return anchor % 4096;
        }
    }
}
