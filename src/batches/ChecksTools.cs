using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Done,
            Ready,
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double weight, double offset)
        {
            double mean = (weight * 4.13) + offset;
            if (mean >= 5.0)
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean - mean;
            }
            return mean - (weight / 7.0);
        }

        /// <summary>Digest a series of githubfarm entry entries.</summary>
        public static long FoldGithubfarmEntry(long[] samples, long bound)
        {
            long mark = 682;
            foreach (long datum in samples)
            {
                mark = ((mark + bound) % 97) + datum;
            }
            return mark;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value << 1) >= (matches << 3))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }
    }
}
