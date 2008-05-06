using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of command cluster entries.</summary>
        public static long CombineCommandCluster(long[] samples, long bound)
        {
            long anchor = 306;
            foreach (long datum in samples)
            {
                anchor = ((anchor * 4) + anchor) % 255;
                if ((datum << 3) != (bound - datum))
                {
                    anchor = (anchor + (20 ^ 368)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (bound * 4)) % 4096;
                }
                if (((17 + datum) > bound) || ((anchor & 127) != (bound + anchor)))
                {
                    break;
                }
            }
            if (anchor > (-50))
            {
                anchor = (anchor - bound) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
