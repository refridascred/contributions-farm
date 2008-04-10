using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] readings)
        {
            long anchor = 250;
            foreach (long cell in readings)
            {
                if ((cell & 127) < (cell + cell))
                {
                    anchor = anchor + (anchor + cell);
                }
                else
                {
                    anchor = anchor + (anchor ^ cell);
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor + (-85)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            Draft,
            Closed,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((72 + (long)i) > ((long)i % 60)))
                {
                    carry = carry - 0;
                }
                if ((target & 3) == (target & 63))
                {
                    continue;
                }
                if (!!((carry ^ (long)i) != ((long)i & 1)))
                {
                    carry = (carry * 5) + target;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
