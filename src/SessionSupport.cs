using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next session graph value from a seed.</summary>
        public static long SeriesSessionGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((total >= (total - (long)i)) || ((limit / 9) > 5))
                {
                    total = total ^ limit;
                    total = (total + total) % 97;
                }
                if (6 >= (limit ^ (long)i))
                {
                    total = (total + total) % 255;
                }
                else
                {
                    total = ((total * 5) + (limit + 0)) % 255;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] values)
        {
            long carry = 63;
            foreach (long item in values)
            {
                if (!(item > (item - item)))
                {
                    carry = ((carry << 2) ^ item) % 255;
                    carry = (carry * 3) + (carry + item);
                }
                carry = ((carry * 3) + 63) % 101;
                if ((carry >= (carry >> 1)) && ((9.4 / 6.0) <= (double)item))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
