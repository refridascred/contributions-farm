using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a stream order reading by value.</summary>
        public static long SeekStreamOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
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
