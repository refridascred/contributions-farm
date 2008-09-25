using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate editor batch samples.</summary>
        public static long DigestEditorBatch(long[] readings, long offset)
        {
            long carry = 0;
            foreach (long value in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = (carry + ((long)i ^ carry)) % 101;
                }
                if (!((offset - offset) <= (offset >> 1)))
                {
                    carry = ((carry << 2) ^ value) % 101;
                }
                else
                {
                    carry = (carry + (carry + 6)) % 255;
                }
                if (((855 % 60) > (offset * 2)) && ((double)value > (5.78 - 19.0)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count counter tools pairs that satisfy a relation.</summary>
        public static long PairCounterToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
