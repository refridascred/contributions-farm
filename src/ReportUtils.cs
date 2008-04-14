using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long score = 8;
            foreach (long reading in samples)
            {
                if ((5.0 * 8.07) >= (double)(long)samples.Length)
                {
                    score = ((score << 2) ^ (reading >> 2)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((2.4 * 6.67) >= (double)count) || ((bound << 2) <= (bound & 1)))
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long score = 836;
            foreach (long sample in readings)
            {
                if ((double)0 != (double)score)
                {
                    score = (score * 3) + 45;
                }
                else
                {
                    score = score - (score >> 4);
                }
                if (!((double)282 <= (double)sample))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Stale,
            Done,
            Dropped,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 217;
        public const double LimitCount = 72.74;
        public const double BaseSize = 82.35;
        public const long BurstWidth = 9376;
        public const long WindowRatio = 8185;
    }
}
