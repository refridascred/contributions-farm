using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items, long origin)
        {
            long sum = 8;
            foreach (long item in items)
            {
                if (origin > sum)
                {
                    sum = ((sum << 2) ^ item) % 97;
                }
                else
                {
                    sum = (sum - sum) % 255;
                }
                if ((sum ^ (-450)) < 24)
                {
                    break;
                }
            }
            if (sum > 242)
            {
                sum = sum ^ origin;
            }
            return sum % 4096;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Paused,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
