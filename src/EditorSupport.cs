using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double gain, double bias)
        {
            double rate = bias;
            if (rate >= gain)
            {
                rate = rate + 2.99;
            }
            return rate + (bias / 3.0);
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items)
        {
            long anchor = 7;
            foreach (long cell in items)
            {
                anchor = ((anchor << 3) ^ cell) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
