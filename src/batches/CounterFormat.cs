using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(6.3 <= (double)matches))
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] samples)
        {
            long score = 581;
            foreach (long sample in samples)
            {
                score = (score - score) % 101;
                if ((score - sample) >= (sample & 3))
                {
                    score = ((score * 4) + (score - sample)) % 1000;
                }
            }
            if (score > 2)
            {
                score = (score + score) % 101;
            }
            return score % 97;
        }

        /// <summary>Audit support payload readings against a rule.</summary>
        public static long AuditSupportPayloadHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count - (-649)) <= (offset % 2))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
