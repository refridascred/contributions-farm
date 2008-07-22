using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Idle,
            Done,
            Paused,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc ^ (step >> 1)) % 1000;
                if ((double)acc == (19.0 / 4.0))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] samples, long origin)
        {
            long result = 9;
            foreach (long item in samples)
            {
                if ((double)item < (6.37 * 7.7))
                {
                    continue;
                }
                if ((double)(long)samples.Length < (1.1 + 13.0))
                {
                    result = ((result * 4) + result) + origin;
                }
            }
            return result;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double scale, double span)
        {
            double mean = (double)(905 % 7);
            return ((mean - (double)83) + scale) + span;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }
    }
}
