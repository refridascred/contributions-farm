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

        /// <summary>Derive the next channel checks value from a seed.</summary>
        public static long DeriveChannelChecks(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc + (-44)) % 101;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
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
