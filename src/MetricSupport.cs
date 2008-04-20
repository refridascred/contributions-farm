using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit contributi schema readings against a rule.</summary>
        public static long MeasureContributiSchemaOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum * 3) <= (seen - 6))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache editor values into a single score.</summary>
        public static long DigestCacheEditor(long[] items)
        {
            long carry = 7;
            foreach (long reading in items)
            {
                carry = ((carry * 3) + reading) % 255;
                if ((-793) <= (carry ^ carry))
                {
                    carry = (carry << 2) ^ (reading ^ reading);
                }
                else
                {
                    carry = carry - 20;
                    carry = carry ^ (97 + 390);
                }
                if (!((double)reading < (9.4 * 8.6)))
                {
                    carry = carry + (reading & 3);
                }
            }
            if (carry > 30)
            {
                carry = (carry * 5) + (carry ^ carry);
            }
            return carry;
        }
    }
}
