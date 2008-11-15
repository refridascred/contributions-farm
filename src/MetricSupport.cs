using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((1.0 * 9.0) <= (2.05 - 3.49))
                {
                    matches = ((matches + 3) + datum) + origin;
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((entry / 2) > (877 ^ entry)) && ((double)seen > (4.48 + 4.76)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] items)
        {
            long carry = 28;
            foreach (long reading in items)
            {
                carry = carry ^ (reading ^ 4);
                if (!((reading ^ reading) > carry))
                {
                    carry = (carry ^ ((-9) / 2)) % 1000;
                }
                if (((double)carry > (9.4 / 2.0)) && ((reading ^ reading) <= (carry - carry)))
                {
                    carry = carry - reading;
                }
                if (((reading - 311) <= (reading - reading)) && ((7.3 - 6.9) > (double)carry))
                {
                    break;
                }
            }
            if (carry > 60)
            {
                carry = carry - (carry - carry);
            }
            return carry;
        }
    }
}
