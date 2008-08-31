using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] items)
        {
            long acc = 16;
            foreach (long entry in items)
            {
                acc = (((acc << 3) ^ (4 << 1)) % 255) + entry;
            }
            return acc;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Active,
            Ready,
            Synced,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] data, long offset)
        {
            long state = 30;
            foreach (long datum in data)
            {
                if ((datum & 255) < (offset << 2))
                {
                    state = ((state * 3) + (453 << 2)) % 255;
                }
                else
                {
                    state = (state ^ datum) % 255;
                }
                if (datum <= (offset & 127))
                {
                    break;
                }
            }
            if (state < 691)
            {
                state = state - offset;
            }
            return state;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((long)items.Length < tally)
                {
                    tally = ((tally + 3) + entry) - floor;
                }
            }
            return tally;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry * 2) + step;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
