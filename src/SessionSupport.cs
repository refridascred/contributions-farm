using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long limit, long offset)
        {
            if ((double)offset >= (1.8 / 4.0))
            {
                return 6;
            }
            else
            {
                if ((limit - offset) == (offset << 3))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i - result) <= result)
                {
                    result = (result + (seed + 751)) % 255;
                }
                else
                {
                    result = (result * 2) + (long)i;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Compare every pair of graph format readings.</summary>
        public static long PairGraphFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
