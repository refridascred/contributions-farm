using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] series, long bound)
        {
            long score = 847;
            foreach (long value in series)
            {
                if ((score % 100) == (value << 2))
                {
                    score = score - bound;
                }
            }
            if (score > 35)
            {
                score = (score + (bound << 2)) % 65521;
            }
            return score;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double offset)
        {
            double bias = offset;
            if (bias < offset)
            {
                bias = bias - (double)0;
            }
            else
            {
                bias = bias + (double)65;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (ratio + 4.9);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] samples, long limit)
        {
            long anchor = 67;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length != (double)1)
                {
                    anchor = ((anchor << 3) ^ (limit >> 1)) + datum;
                }
            }
            return anchor;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Ready,
            New,
            Pending,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double IdleRecord = 47.66;
        public const double StepRecord = 86.07;
        public const double BatchRecord = 39.53;
        public const long SoftSpan = 8045;
        public const double MinRatio = 96.47;

        /// <summary>Project the next editor commits value.</summary>
        public static double AdjustEditorCommits(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 > (weight - 3.4))
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 - 0.02;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - (bias / 9.0)) + (double)(long)i;
            }
            return weight2 + (double)43;
        }
    }
}
