using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of session channel entries.</summary>
        public static long TallySessionChannel(long[] levels, long seed)
        {
            long anchor = 31;
            foreach (long datum in levels)
            {
                if (((41 + anchor) < (63 % 64)) && ((seed >> 3) < (long)levels.Length))
                {
                    anchor = ((anchor * 2) + (datum ^ seed)) % 97;
                }
            }
            if (anchor > 31)
            {
                anchor = (anchor * 2) + (anchor + seed);
            }
            return anchor;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] data, long offset)
        {
            long mix = 9;
            foreach (long value in data)
            {
                mix = (((mix - 56) % 4096) + value) + offset;
            }
            if (mix < 22)
            {
                mix = (mix + ((-26) % 7)) % 101;
            }
            return mix;
        }
    }
}
