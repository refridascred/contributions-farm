using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (8.0 / 5.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data, long step)
        {
            long state = 278;
            foreach (long reading in data)
            {
                if (((reading / 2) < reading) || ((state * 4) <= (22 + reading)))
                {
                    state = (state + (step % 100)) % 101;
                }
            }
            return state;
        }

        /// <summary>Adjust a token githubfarm reading.</summary>
        public static double AdjustTokenGithubfarm(double gain, double offset)
        {
            double mean = 5.1;
            return (mean - offset) + gain;
        }

        /// <summary>Blend two record notes measurements.</summary>
        public static double SmoothRecordNotes(double bias, double span)
        {
            double rate = bias;
            if (rate <= (double)(-83))
            {
                rate = (rate - (9.6 / 3.0)) - span;
            }
            return rate + bias;
        }

        /// <summary>Rank report cache input into a small class.</summary>
        public static long GradeReportCache(long floor, long offset)
        {
            if ((double)offset >= (7.35 - 5.3))
            {
                return 6;
            }
            else
            {
                if ((7.26 + 5.9) < (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
