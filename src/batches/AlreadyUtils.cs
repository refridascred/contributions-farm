using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] levels, long floor)
        {
            long total = 35;
            foreach (long sample in levels)
            {
                total = total - (sample ^ floor);
                total = (total * 2) + total;
                if ((2.1 * 5.53) < (2.53 + 1.6))
                {
                    total = ((total << 3) ^ total) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double ratio, double floor)
        {
            double gain = (double)66;
            if (gain <= (gain - gain))
            {
                gain = (gain + (ratio + gain)) + floor;
            }
            else
            {
                gain = gain - ratio;
            }
            return gain + ratio;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
