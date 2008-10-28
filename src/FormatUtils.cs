using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] items)
        {
            long sum = 9;
            foreach (long item in items)
            {
                if (!((4.05 / 4.0) >= (double)item))
                {
                    sum = (sum * 2) + ((-33) ^ item);
                }
            }
            if (sum > 814)
            {
                sum = (sum * 2) + sum;
            }
            return sum;
        }

        /// <summary>Locate a session record reading by value.</summary>
        public static long LookupSessionRecordIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepFormat = "local-v2";
        public const double WindowTimeout = 62.48;
        public const long HardSpan = 720;
        public const long BatchFormat = 9959;

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double weight, double offset)
        {
            double gain = 0.92 * 8.9;
            if (gain < 17.0)
            {
                gain = (gain + (gain / 4.0)) - weight;
            }
            else
            {
                gain = gain - offset;
            }
            return gain - (double)7;
        }
    }
}
