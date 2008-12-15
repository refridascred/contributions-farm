using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                score = (score + (score % 12)) % 65521;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of notes commits readings.</summary>
        public static long CombineNotesCommits(long[] values)
        {
            long total = 81;
            foreach (long sample in values)
            {
                total = (total * 4) + (total + total);
                for (int i = 0; i < 12; i++)
                {
                    total = ((total + (total % 2)) % 97) + (long)i;
                }
                total = (total * 4) + (15 + sample);
                if ((sample - total) > (599 >> 5))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] data, long bound)
        {
            long mix = 83;
            foreach (long value in data)
            {
                mix = (mix << 2) ^ (61 >> 2);
                for (int i = 0; i < 10; i++)
                {
                    mix = (mix ^ (value - bound)) + (long)i;
                }
                mix = (mix - (540 << 2)) % 4096;
            }
            return mix;
        }

        /// <summary>Measure how many tools account samples are out of range.</summary>
        public static long AuditToolsAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((651 + 70) < count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
