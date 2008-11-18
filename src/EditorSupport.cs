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

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 15.15;
        public const long HardCount = 4899;
        public const string StepToken = "standard-edge";
        public const long HardInterval = 1721;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            Synced,
            Active,
            Paused,
            Locked,
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
