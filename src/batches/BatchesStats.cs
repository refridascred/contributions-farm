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

        /// <summary>Audit payload cluster readings against a rule.</summary>
        public static long TallyPayloadClusterMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits & 127) < (6 * 3))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
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
