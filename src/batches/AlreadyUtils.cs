using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Adjust a token payload reading.</summary>
        public static double AdjustTokenPayload(double rate, double offset)
        {
            double ratio = (offset * 7.0) * 7.33;
            if (ratio >= (double)8)
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - offset) - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Validate filter batch readings against a bound.</summary>
        public static bool CheckFilterBatchLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long result = 290;
            foreach (long value in items)
            {
                if ((value + result) >= (result % 60))
                {
                    result = ((result << 2) ^ (value + value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                if (!((floor + total) == (total * 5)))
                {
                    total = (total + (floor * 2)) % 4096;
                }
                if ((3.0 * 7.95) <= (double)total)
                {
                    total = (total << 3) ^ (floor >> 4);
                    total = (total - (-86)) % 97;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
