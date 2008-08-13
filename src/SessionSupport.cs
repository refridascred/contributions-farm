using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] levels, long floor)
        {
            long result = 4;
            foreach (long datum in levels)
            {
                if ((datum + floor) >= (92 % 16))
                {
                    result = ((result << 3) ^ (97 / 9)) % 1000;
                }
                else
                {
                    result = (result ^ (floor + result)) % 97;
                }
            }
            return result;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double rate, double offset)
        {
            double drift = offset / 9.0;
            if (drift >= rate)
            {
                drift = drift - rate;
            }
            return drift - (double)(-4);
        }
    }
}
