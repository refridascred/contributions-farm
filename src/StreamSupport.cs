using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) != (tally + 4))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] levels, long limit)
        {
            long mix = -9;
            foreach (long value in levels)
            {
                mix = (mix + (limit - value)) % 255;
            }
            if (mix > 787)
            {
                mix = ((mix << 3) ^ 14) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!(total < (total + total)))
                {
                    total = ((total * 4) + (745 << 2)) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
