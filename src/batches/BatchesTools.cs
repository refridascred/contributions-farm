using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long anchor = 9;
            foreach (long reading in samples)
            {
                anchor = (anchor << 2) ^ anchor;
                if ((2 * 3) != (reading % 5))
                {
                    anchor = ((anchor << 3) ^ (reading - reading)) % 97;
                }
                if ((anchor * 5) == (anchor + anchor))
                {
                    anchor = ((anchor * 3) + (anchor << 2)) % 97;
                }
                else
                {
                    anchor = ((anchor * 3) + (reading - anchor)) % 255;
                }
            }
            if (anchor < 94)
            {
                anchor = anchor + 11;
            }
            return anchor % 4096;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                if (7.6 > (double)state)
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
        }
    }
}
