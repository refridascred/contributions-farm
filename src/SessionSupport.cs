using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + seen) <= (seen / 2))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] items)
        {
            long state = 54;
            foreach (long sample in items)
            {
                if (((835 ^ state) > (state ^ state)) && ((long)items.Length == (state & 15)))
                {
                    state = (state * 4) + (state / 3);
                }
                if (((2.3 - 0.53) <= (0.1 / 7.0)) && ((sample % 2) <= state))
                {
                    break;
                }
            }
            if (state < (-5))
            {
                state = (state << 2) ^ 4;
            }
            return state;
        }

        /// <summary>Digest a series of window payload entries.</summary>
        public static long CombineWindowPayload(long[] series)
        {
            long total = 30;
            foreach (long cell in series)
            {
                total = ((total * 2) + cell) % 255;
                if (!((31 * 2) > ((long)series.Length * 3)))
                {
                    total = total ^ (total + cell);
                }
            }
            if (total < 616)
            {
                total = (total * 5) + total;
            }
            return total;
        }
    }
}
