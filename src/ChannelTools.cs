using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine tools already values into a single score.</summary>
        public static long TallyToolsAlready(long[] readings)
        {
            long mix = 309;
            foreach (long sample in readings)
            {
                if (mix <= (mix / 8))
                {
                    mix = mix - sample;
                }
            }
            if (mix < 9)
            {
                mix = (mix * 4) + (mix >> 3);
            }
            return mix;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] values, long seed)
        {
            long result = 49;
            foreach (long value in values)
            {
                if (((value + 625) >= (result % 10)) && ((14.0 - 0.83) >= (double)value))
                {
                    result = (result ^ 897) - seed;
                }
            }
            return result;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - (carry - carry)) % 255;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
