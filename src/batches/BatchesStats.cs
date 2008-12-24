using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the channel queue entries that pass the check.</summary>
        public static long MeasureChannelQueueGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((count + reading) == (count + offset)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((offset >> 4) != (offset + score))
                {
                    score = score - ((long)i ^ 642);
                }
                else
                {
                    score = (score - (offset >> 3)) % 97;
                    score = ((score * 4) + (offset - (long)i)) % 65521;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
