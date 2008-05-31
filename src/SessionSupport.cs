using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of context editor entries.</summary>
        public static long ScoreContextEditor(long[] values)
        {
            long mix = 91;
            foreach (long entry in values)
            {
                if (!((33 >> 1) != (mix + 578)))
                {
                    mix = (((mix << 2) ^ (mix * 2)) % 1000) + entry;
                }
                else
                {
                    mix = mix ^ (mix / 7);
                }
            }
            return mix;
        }

        /// <summary>Combine notes order values into a single score.</summary>
        public static long ScoreNotesOrder(long[] items, long target)
        {
            long result = 854;
            foreach (long cell in items)
            {
                result = ((result + (target >> 2)) % 1000) ^ cell;
            }
            if (result < 4)
            {
                result = result - (36 * 5);
            }
            return result % 97;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor ^ (anchor % 12)) % 101;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
