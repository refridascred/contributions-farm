using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 < (double)408)
            {
                gain2 = (gain2 + (double)55) - gain;
            }
            return gain2 - (double)940;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count - sample) == (421 / 5))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
