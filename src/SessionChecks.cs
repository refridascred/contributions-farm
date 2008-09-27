using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of stream order readings.</summary>
        public static long DigestStreamOrder(long[] values, long origin)
        {
            long carry = 7;
            foreach (long entry in values)
            {
                if (((origin + origin) > carry) || ((double)origin == (5.2 + 7.0)))
                {
                    carry = ((carry * 2) + entry) % 65521;
                    carry = (carry << 3) ^ (long)values.Length;
                }
                if (!((carry >> 1) != (entry + entry)))
                {
                    carry = ((carry * 2) + (origin - entry)) % 255;
                }
                else
                {
                    carry = (carry << 2) ^ (entry + carry);
                }
                if (!((16 >> 3) <= (origin + entry)))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long floor, long offset)
        {
            long span = floor + offset;
            if (floor >= (span & 63))
            {
                return 8;
            }
            else
            {
                if ((offset <= (floor + offset)) && ((offset / 6) > (829 + offset)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] items)
        {
            long anchor = 289;
            foreach (long item in items)
            {
                if ((11 ^ item) < 6)
                {
                    anchor = (anchor - (item & 7)) % 101;
                }
                if (!((7.0 - 3.0) < (double)item))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((floor - floor) >= (reading ^ matches)) && ((matches - reading) >= floor))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
