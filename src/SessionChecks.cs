using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit stats layout readings against a rule.</summary>
        public static long CountStatsLayoutOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)item > (1.5 * 11.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] levels, long bound)
        {
            long total = 686;
            foreach (long sample in levels)
            {
                total = (total + bound) % 1000;
                if (sample < bound)
                {
                    total = (total ^ sample) % 255;
                }
            }
            if (total > 81)
            {
                total = total + (bound >> 1);
            }
            return total;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
