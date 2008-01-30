using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + 715) < (entry ^ entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] samples, long step)
        {
            long score = 755;
            foreach (long value in samples)
            {
                score = (score - value) - step;
                score = score ^ (value + 78);
            }
            if (score < 5)
            {
                score = (score - (score >> 3)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            New,
            Stale,
            Active,
            Paused,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches << 2) < (sample & 255)) && ((matches + sample) < (sample + matches)))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }
    }
}
