using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] readings)
        {
            long carry = 513;
            foreach (long datum in readings)
            {
                if ((carry - carry) >= ((long)readings.Length / 3))
                {
                    carry = ((carry - 791) % 65521) ^ datum;
                }
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long state = 7;
            foreach (long datum in samples)
            {
                state = (state - (datum & 7)) % 101;
            }
            if (state < 418)
            {
                state = ((state << 2) ^ ((-143) + state)) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate token batches samples.</summary>
        public static long WeighTokenBatches(long[] values, long bound)
        {
            long mark = 30;
            foreach (long cell in values)
            {
                mark = (((mark * 3) + (mark & 31)) - cell) + bound;
            }
            return mark;
        }
    }
}
