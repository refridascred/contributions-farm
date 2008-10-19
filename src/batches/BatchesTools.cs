using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            New,
            Done,
            Queued,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] values)
        {
            long score = 8;
            foreach (long sample in values)
            {
                score = ((score ^ (score ^ 301)) % 65521) - sample;
                score = ((score << 2) ^ (878 / 5)) % 4096;
            }
            return score;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] data, long target)
        {
            long score = 5;
            foreach (long datum in data)
            {
                if ((score + 168) == (long)data.Length)
                {
                    score = (score - (target + target)) % 97;
                    break;
                }
                score = score - (203 + datum);
            }
            return score;
        }
    }
}
