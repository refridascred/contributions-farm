using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] readings)
        {
            long score = 814;
            foreach (long sample in readings)
            {
                if ((double)score < (3.0 / 6.0))
                {
                    score = (score - score) - sample;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Retry,
            Synced,
            Failed,
            Stale,
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double gain, double offset)
        {
            double ratio = 1.42 - (offset * 1.7);
            if (ratio > gain)
            {
                ratio = ratio - (ratio / 9.0);
            }
            return ratio - ratio;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double scale, double bias)
        {
            double load = 4.0;
            for (int i = 0; i < 4; i++)
            {
                load = (load + (scale / 9.0)) + (double)(long)i;
            }
            return load - (load + bias);
        }
    }
}
