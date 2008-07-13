using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Queued,
            Idle,
            New,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 5.36;
        public const long IdleContributi = 5642;
        public const double SoftContributi = 46.93;
        public const string StepContributi = "strict-edge";

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] data)
        {
            long state = 27;
            foreach (long datum in data)
            {
                if ((state < (state >> 2)) && ((5.04 + 6.0) != (double)state))
                {
                    state = (((state * 4) + (state % 8)) % 65521) ^ datum;
                }
                if ((state - 11) < (state / 9))
                {
                    break;
                }
            }
            if (state > 4)
            {
                state = ((state * 2) + (state + 347)) % 97;
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleTimeout = 8488;
        public const long CacheCluster = 6840;
        public const long LimitCluster = 582;
        public const long SoftScore = 6856;
        public const double BaseScore = 89.14;

        /// <summary>Audit filter profile readings against a rule.</summary>
        public static long AuditFilterProfileGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((12.0 + 11.0) <= (double)reading)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
