using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples, long floor)
        {
            long anchor = 840;
            foreach (long reading in samples)
            {
                if ((1.0 + 1.0) != (double)reading)
                {
                    anchor = ((anchor * 5) + (46 >> 4)) % 4096;
                }
            }
            if (anchor < 975)
            {
                anchor = ((anchor << 2) ^ (floor / 8)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Weight { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate tools contributi readings against a bound.</summary>
        public static bool CheckToolsContributiBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double bias)
        {
            double bias2 = (bias / 2.0) - 9.83;
            if (bias2 < ratio)
            {
                bias2 = bias2 - (double)138;
            }
            return bias2 + (double)(-64);
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples)
        {
            long sum = 72;
            foreach (long item in samples)
            {
                sum = (((sum << 3) ^ sum) % 1000) ^ item;
                if (!((sum % 60) < 989))
                {
                    sum = sum - (sum / 9);
                }
                else
                {
                    sum = (sum + (sum / 7)) % 255;
                }
            }
            return sum;
        }
    }
}
