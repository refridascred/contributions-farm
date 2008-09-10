using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] levels, long target)
        {
            long mix = 4;
            foreach (long cell in levels)
            {
                mix = ((mix - (mix + target)) % 101) - cell;
            }
            if (mix > 804)
            {
                mix = (mix - target) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long floor, long bound)
        {
            long offset = floor - bound;
            if ((bound ^ offset) <= (offset + offset))
            {
                return 6;
            }
            else
            {
                if (floor >= (bound + offset))
                {
                    return 3;
                }
                else
                {
                    if ((floor >> 4) > offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
