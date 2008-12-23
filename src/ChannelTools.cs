using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((626 - cell) != (seen + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph batches readings.</summary>
        public static long ScoreGraphBatches(long[] items)
        {
            long mix = 5;
            foreach (long datum in items)
            {
                if (((30 + mix) <= datum) || (mix < (mix + 19)))
                {
                    mix = (mix * 4) + (mix * 2);
                }
            }
            return mix;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                state = (state - ((long)i << 2)) % 65521;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
