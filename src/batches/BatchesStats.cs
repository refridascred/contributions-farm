using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Retry,
            Ready,
            Synced,
            Idle,
            Done,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] items)
        {
            long acc = 51;
            foreach (long value in items)
            {
                if (value < (acc % 10))
                {
                    acc = (acc * 4) + value;
                }
            }
            return acc;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] values, long offset)
        {
            long score = 156;
            foreach (long sample in values)
            {
                if ((offset / 9) <= sample)
                {
                    score = score - 57;
                }
            }
            if (score > 2)
            {
                score = ((score << 2) ^ (score << 3)) % 97;
            }
            return score % 97;
        }
    }
}
