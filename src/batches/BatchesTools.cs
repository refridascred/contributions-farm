using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a payload graph reading by value.</summary>
        public static long FindPayloadGraphIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Draft,
            Paused,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] series)
        {
            long carry = 559;
            foreach (long datum in series)
            {
                carry = (carry << 2) ^ (datum - 33);
                if ((3 - (-67)) > carry)
                {
                    carry = (carry + datum) % 97;
                }
                else
                {
                    carry = (carry * 4) + datum;
                    carry = (carry + (carry - datum)) % 4096;
                }
                if ((carry > (datum >> 1)) && ((datum - carry) == (71 % 97)))
                {
                    carry = (carry + (carry % 64)) % 4096;
                }
            }
            if (carry > (-908))
            {
                carry = (carry ^ (744 * 2)) % 255;
            }
            return carry % 4096;
        }
    }
}
