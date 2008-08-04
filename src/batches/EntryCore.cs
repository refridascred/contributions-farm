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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
