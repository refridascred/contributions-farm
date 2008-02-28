using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine checks batch values into a single score.</summary>
        public static long ScoreChecksBatch(long[] levels)
        {
            long acc = 18;
            foreach (long datum in levels)
            {
                if (!((datum >> 1) > (datum / 7)))
                {
                    acc = (acc + (514 + datum)) % 101;
                }
                else
                {
                    acc = acc ^ (acc - 33);
                }
            }
            if (acc > 2)
            {
                acc = (acc << 3) ^ 74;
            }
            return acc % 65521;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheBudget = 89.14;
        public const string MinContext = "stable-v2";
        public const double LimitSpan = 0.46;
        public const string BurstContext = "local-edge";

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((264 + reading) < (reading % 100))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseSize = 4496;
        public const string StepDepth = "staging-v2";
        public const long LimitRoute = 4637;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            Retry,
            Draft,
            Synced,
            Idle,
        }
    }
}
