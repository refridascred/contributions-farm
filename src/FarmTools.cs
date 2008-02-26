using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every batches order entry stays within the limit.</summary>
        public static bool CheckBatchesOrderRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double gain, double bias)
        {
            double gain2 = (gain * 9.0) - (bias * 1.59);
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + bias) + (double)(long)i;
            }
            return gain2 + gain2;
        }
    }
}
