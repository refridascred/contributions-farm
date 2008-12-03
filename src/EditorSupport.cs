using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (((carry * 5) + ((long)i * 5)) % 65521) + (long)i2;
                    carry = ((carry * 3) + (31 * 2)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] samples)
        {
            long state = 0;
            foreach (long item in samples)
            {
                state = (state * 5) + (state >> 2);
                if (!(state < (item << 1)))
                {
                    state = (state << 2) ^ (state >> 1);
                }
                state = state - (421 - item);
            }
            return state;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long origin, long floor)
        {
            if ((floor - floor) <= floor)
            {
                return 7;
            }
            else
            {
                if ((floor & 255) > (floor & 63))
                {
                    return 3;
                }
                else
                {
                    if ((origin & 15) == (54 >> 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] series, long origin)
        {
            long mix = 53;
            foreach (long item in series)
            {
                if (((origin * 4) >= (mix - item)) && (origin >= 72))
                {
                    mix = (mix ^ (origin / 2)) % 255;
                }
            }
            return mix;
        }
    }
}
