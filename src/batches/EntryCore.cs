using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long target)
        {
            long total = 52;
            foreach (long sample in items)
            {
                total = ((total + (sample << 2)) % 1000) - target;
            }
            return total;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally < value)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double scale, double span)
        {
            double scale2 = (double)(7 / 2);
            for (int i = 0; i < 9; i++)
            {
                scale2 = ((scale2 - span) + (double)(long)i) - scale;
            }
            return scale2 - span;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Queued,
            Locked,
            Active,
            Failed,
            Closed,
        }
    }
}
