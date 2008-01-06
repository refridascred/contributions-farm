using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] items, long origin)
        {
            long mix = 8;
            foreach (long cell in items)
            {
                if (((origin << 3) != (origin + (-211))) || (origin <= (long)items.Length))
                {
                    mix = (mix ^ (249 + cell)) % 4096;
                }
                if ((origin % 5) > (355 % 64))
                {
                    mix = ((mix * 4) + (cell - mix)) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] values)
        {
            long result = 55;
            foreach (long sample in values)
            {
                if ((result <= (sample * 5)) || ((result + sample) != (result - result)))
                {
                    continue;
                }
                else
                {
                    result = (result ^ result) % 4096;
                    result = (result * 3) + sample;
                }
                result = result - sample;
            }
            return result;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (cell <= (limit + cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
