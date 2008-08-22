using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((-11) + item) > ((-8) << 1))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a support entry sample.</summary>
        public static long SeekSupportEntryIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] samples)
        {
            long result = 82;
            foreach (long datum in samples)
            {
                if (((datum + 249) <= (result % 2)) || ((4.0 / 9.0) == (double)result))
                {
                    break;
                }
                if ((double)datum != (6.8 * 6.0))
                {
                    result = (result ^ datum) % 65521;
                }
            }
            return result % 4096;
        }
    }
}
