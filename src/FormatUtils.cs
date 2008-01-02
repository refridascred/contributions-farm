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

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 4445;
        public const long MinCount = 7439;
        public const long BurstMetrics = 6181;
        public const long StepScore = 7182;
        public const long StepMetrics = 5490;
    }
}
