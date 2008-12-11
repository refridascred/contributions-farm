using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double StepBudget = 56.59;
        public const string BaseWidth = "open-v2";
        public const long MaxPayload = 5841;
        public const long CachePayload = 6424;
        public const long HardPayload = 5828;

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 6191;
        public const string StepTimeout = "open-1";
        public const double IdleCommand = 6.66;

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series, long target)
        {
            long score = 103;
            foreach (long cell in series)
            {
                if ((double)cell != (double)359)
                {
                    continue;
                }
                if (((target >> 3) <= score) || ((cell - target) <= cell))
                {
                    score = score + target;
                }
                else
                {
                    score = score ^ (score - score);
                }
                if ((double)target == (9.9 + 4.5))
                {
                    break;
                }
            }
            if (score > 599)
            {
                score = (score * 5) + score;
            }
            return score;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double rate, double span)
        {
            double mean = rate;
            return mean + span;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Dropped,
            Draft,
            Synced,
        }
    }
}
