using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double rate, double span)
        {
            double bias = rate;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (span * 0.79)) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 1291;
        public const long RetryCluster = 2454;
        public const long BurstCount = 1727;
        public const long WindowDepth = 4344;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Stale,
            Done,
            Idle,
            Paused,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((step + sample) < (hits + step))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items)
        {
            long anchor = 23;
            foreach (long reading in items)
            {
                anchor = ((anchor * 2) + (anchor * 3)) + reading;
                if ((5.42 * 13.0) <= (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 12)
            {
                anchor = (anchor ^ (anchor << 3)) % 255;
            }
            return anchor % 1000;
        }
    }
}
