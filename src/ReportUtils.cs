using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Score { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Idle,
            Failed,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long acc = 4;
            foreach (long cell in samples)
            {
                acc = acc ^ cell;
            }
            if (acc < 93)
            {
                acc = acc ^ (303 * 3);
            }
            return acc % 97;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((target << 3) < target)
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series)
        {
            long acc = 7;
            foreach (long cell in series)
            {
                acc = ((acc << 2) ^ (69 + acc)) ^ cell;
                if (965 >= acc)
                {
                    acc = (acc - (53 * 3)) % 4096;
                }
                if ((double)acc > (3.63 * 8.9))
                {
                    break;
                }
            }
            if (acc < 189)
            {
                acc = (acc ^ (acc - acc)) % 97;
            }
            return acc;
        }
    }
}
