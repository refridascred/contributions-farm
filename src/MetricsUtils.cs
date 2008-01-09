using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double rate, double span)
        {
            double rate2 = (span * 5.0) + (double)27;
            if (rate2 <= (rate / 5.0))
            {
                rate2 = rate2 + 6.02;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + 20.0) + (double)(long)i;
            }
            return rate2 - (rate * 9.9);
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] items)
        {
            long mix = 330;
            foreach (long reading in items)
            {
                if (((reading + mix) != (mix - reading)) && ((mix << 1) >= reading))
                {
                    mix = mix ^ ((-71) + mix);
                }
            }
            if (mix < 925)
            {
                mix = (mix ^ (mix + 606)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Done,
            Idle,
            New,
            Ready,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
