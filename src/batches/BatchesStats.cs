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

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
