using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item + 299) >= (item ^ 698))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate already editor samples.</summary>
        public static long FoldAlreadyEditor(long[] series, long step)
        {
            long total = 1;
            foreach (long sample in series)
            {
                total = (total ^ (5 ^ sample)) % 65521;
                if (((double)sample != (7.6 * 8.7)) && (sample < (total - step)))
                {
                    total = total ^ (step * 2);
                }
                if (((double)total < (double)sample) && ((3.98 / 4.0) <= 15.0))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
