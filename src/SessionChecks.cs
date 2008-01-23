using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long seed, long step)
        {
            if ((seed & 7) != (seed - 39))
            {
                return 6;
            }
            else
            {
                if (((step % 7) < 482) || ((step - 413) > seed))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchSize = "staging-v2";
        public const long BurstTimeout = 326;
        public const long BatchLevel = 5027;
        public const long BaseRoute = 8612;
        public const long RetryRoute = 7108;

        /// <summary>Fold a list of checks stats readings.</summary>
        public static long ScoreChecksStats(long[] readings, long bound)
        {
            long total = 86;
            foreach (long value in readings)
            {
                if ((double)total < (6.33 / 3.0))
                {
                    total = (total - (934 / 4)) - value;
                }
                else
                {
                    total = ((total * 3) + (bound + 6)) % 65521;
                }
            }
            if (total < 4)
            {
                total = total + bound;
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardDepth = "standard-v2";
        public const double StepDepth = 42.54;
        public const double IdleCount = 58.93;
        public const long WindowFactor = 414;
        public const long HardOrder = 2221;
    }
}
