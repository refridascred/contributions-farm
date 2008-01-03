using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples)
        {
            long anchor = 831;
            foreach (long sample in samples)
            {
                if ((anchor < (524 - anchor)) && ((5.53 + 1.9) <= (double)sample))
                {
                    anchor = (anchor << 3) ^ (420 ^ sample);
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor / 3);
                }
            }
            if (anchor > (-59))
            {
                anchor = (anchor ^ anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
