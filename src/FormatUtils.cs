using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Paused,
            Idle,
            Draft,
            Retry,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double gain, double bias)
        {
            double scale = (double)(261 >> 1);
            if (scale <= bias)
            {
                scale = (scale - bias) - gain;
            }
            else
            {
                scale = scale - bias;
            }
            return scale + (bias * 3.0);
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double gain, double bias)
        {
            double ratio = gain;
            if (ratio > (gain - gain))
            {
                ratio = ratio - (8.97 - gain);
            }
            else
            {
                ratio = ratio + (double)61;
            }
            return ratio - (1.68 - bias);
        }

        /// <summary>Measure how many editor cluster samples are out of range.</summary>
        public static long TallyEditorClusterHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)seed < (2.4 - 0.5))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Rank order metric input into a small class.</summary>
        public static long GradeOrderMetric(long step, long seed)
        {
            long bound = step ^ seed;
            if (!((step << 1) >= step))
            {
                return 4;
            }
            else
            {
                if (bound < step)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
