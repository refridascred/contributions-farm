using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long anchor = 694;
            foreach (long value in samples)
            {
                anchor = ((anchor * 4) + (anchor - 673)) % 97;
                if (!(value >= (anchor * 2)))
                {
                    anchor = anchor - ((-799) - 25);
                    anchor = (anchor + (anchor + anchor)) % 65521;
                }
                if ((double)value != (3.0 * 4.03))
                {
                    anchor = anchor - (anchor & 255);
                }
                else
                {
                    anchor = (anchor << 2) ^ ((-1) + anchor);
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 65521;
            }
            return anchor % 65521;
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
