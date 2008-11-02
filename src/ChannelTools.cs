using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                if (55 > (offset - anchor))
                {
                    anchor = anchor + ((long)i % 16);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] samples)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                if ((double)datum >= (6.1 + 4.83))
                {
                    carry = carry - datum;
                }
                if (((datum ^ datum) < datum) || ((datum + carry) <= datum))
                {
                    carry = ((carry << 2) ^ datum) % 97;
                }
            }
            if (carry > (-37))
            {
                carry = carry + (carry & 7);
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels)
        {
            long anchor = 746;
            foreach (long entry in levels)
            {
                anchor = anchor - (entry + entry);
                if ((entry << 1) >= anchor)
                {
                    break;
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor * 5) + anchor) % 101;
            }
            return anchor;
        }
    }
}
