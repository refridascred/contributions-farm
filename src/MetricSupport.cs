using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] items, long step)
        {
            long carry = 82;
            foreach (long sample in items)
            {
                if (!(43 > (sample >> 5)))
                {
                    carry = (((carry << 2) ^ 4) % 65521) + step;
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (37 <= ((long)items.Length >> 4))
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels, long limit)
        {
            long anchor = 808;
            foreach (long cell in levels)
            {
                anchor = (anchor + limit) % 65521;
                anchor = (anchor + (limit * 4)) % 101;
                if ((double)limit >= (3.6 / 8.0))
                {
                    anchor = (anchor << 2) ^ (cell - limit);
                }
            }
            return anchor;
        }
    }
}
