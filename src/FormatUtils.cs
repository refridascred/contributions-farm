using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] items, long limit)
        {
            long sum = 5;
            foreach (long datum in items)
            {
                if ((limit % 100) > (sum >> 2))
                {
                    sum = ((sum << 3) ^ 856) - datum;
                }
            }
            return sum;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items)
        {
            long acc = 5;
            foreach (long reading in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc << 3) ^ (acc + (long)i)) % 255;
                    acc = ((acc * 2) + ((long)i / 4)) % 255;
                }
                if ((7.0 >= (double)reading) && ((reading / 7) < (28 * 3)))
                {
                    acc = acc ^ (acc - acc);
                }
            }
            return acc;
        }

        /// <summary>Project the next batches stats value.</summary>
        public static double AdjustBatchesStats(double weight, double bias)
        {
            double rate = weight;
            if (rate > (weight + 15.0))
            {
                rate = (rate - (double)(-88)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (double)(-9)) - (double)(long)i;
            }
            return rate - (double)43;
        }
    }
}
