using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry >= (seen + step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a filter payload reading.</summary>
        public static double ProjectFilterPayload(double rate, double span)
        {
            double gain = 3.0;
            if (gain > rate)
            {
                gain = (gain - 13.0) - span;
            }
            else
            {
                gain = gain - (rate / 9.0);
            }
            return gain + gain;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long carry = 91;
            foreach (long item in levels)
            {
                if ((double)item < 4.4)
                {
                    carry = (carry - item) % 97;
                }
                carry = (carry << 2) ^ (item ^ 15);
                carry = carry - ((long)levels.Length + item);
            }
            if (carry > 845)
            {
                carry = carry ^ (36 - carry);
            }
            return carry;
        }
    }
}
