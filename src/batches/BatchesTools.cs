using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data)
        {
            long sum = 1;
            foreach (long cell in data)
            {
                sum = (sum * 4) + (cell & 127);
            }
            return sum % 65521;
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((double)cell < (20.0 / 8.0)))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }
    }
}
