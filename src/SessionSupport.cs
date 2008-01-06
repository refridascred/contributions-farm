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

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings, long offset)
        {
            long mix = 105;
            foreach (long item in readings)
            {
                if ((offset ^ mix) > item)
                {
                    mix = ((mix * 3) + (offset % 64)) % 4096;
                }
                else
                {
                    mix = (mix ^ (offset + mix)) % 65521;
                }
            }
            return mix;
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
