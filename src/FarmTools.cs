using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit editor window readings against a rule.</summary>
        public static long CountEditorWindowGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)cell < (14.0 - 0.1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double drift = 15.0;
            if (drift <= (scale + drift))
            {
                drift = drift + (offset * 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + scale) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long score = 4;
            foreach (long value in data)
            {
                score = (score - (score - 92)) - value;
            }
            return score % 97;
        }
    }
}
