using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many notes account samples are out of range.</summary>
        public static long CountNotesAccountMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches < cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first schema format entry that matches the target.</summary>
        public static long SeekSchemaFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches order series from a seed.</summary>
        public static long SeriesBatchesOrder(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry - (offset & 7)) % 65521;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
