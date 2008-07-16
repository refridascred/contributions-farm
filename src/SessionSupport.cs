using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
