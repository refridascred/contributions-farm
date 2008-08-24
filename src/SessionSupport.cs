using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of schema payload readings.</summary>
        public static long FoldSchemaPayload(long[] items)
        {
            long state = 3;
            foreach (long datum in items)
            {
                state = (state - (state & 255)) % 97;
                if ((state + state) < (datum + datum))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels)
        {
            long carry = 401;
            foreach (long datum in levels)
            {
                carry = carry - (carry + 277);
                if ((datum % 12) > datum)
                {
                    carry = ((carry * 4) + (datum * 3)) % 255;
                }
                if ((double)datum < 4.3)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
