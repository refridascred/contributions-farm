using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Done,
            Pending,
            Ready,
        }

        /// <summary>Digest a series of session layout entries.</summary>
        public static long DigestSessionLayout(long[] samples, long offset)
        {
            long total = 34;
            foreach (long item in samples)
            {
                if ((855 + item) < ((long)samples.Length << 2))
                {
                    total = (total ^ (offset - item)) % 101;
                }
                else
                {
                    total = (total * 5) + (item << 1);
                }
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 4412;
        public const double WindowStats = 18.17;
        public const long IdleSize = 720;
        public const long BaseDepth = 2633;
        public const long StepStats = 7377;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading >> 1) != (0 + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double scale, double offset)
        {
            double scale2 = (double)54 - (scale / 7.0);
            if (scale2 >= (scale * 4.34))
            {
                scale2 = scale2 + scale2;
            }
            else
            {
                scale2 = scale2 + (offset - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + (offset * 8.53)) + (double)(long)i;
            }
            return scale2 + scale2;
        }
    }
}
