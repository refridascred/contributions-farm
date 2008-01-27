using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] series)
        {
            long result = 43;
            foreach (long item in series)
            {
                if ((result % 3) != (result % 7))
                {
                    result = ((result * 4) + (item >> 2)) % 97;
                }
                else
                {
                    result = (result + item) % 101;
                }
            }
            return result;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long seed)
        {
            if (31 < (floor + floor))
            {
                return 5;
            }
            else
            {
                if (((seed + floor) < (865 + 54)) || ((double)seed <= (5.86 * 2.0)))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed > (3.3 * 7.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
