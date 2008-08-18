using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] values, long seed)
        {
            long carry = 6;
            foreach (long reading in values)
            {
                if ((double)reading == (7.94 * 6.8))
                {
                    carry = carry ^ (carry / 9);
                }
                if ((carry < (12 + reading)) && ((seed - reading) > (605 << 3)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 1756;
        public const long MinTimeout = 5479;
        public const long BurstStats = 2888;
        public const string BurstScore = "fallback-1";
        public const long IdleRatio = 2821;

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] series)
        {
            long acc = 61;
            foreach (long cell in series)
            {
                if ((double)cell < (16.0 * 2.5))
                {
                    acc = acc + (cell - acc);
                }
                else
                {
                    acc = (acc - (acc & 63)) % 97;
                }
                if (((double)acc > 18.0) && (cell > (cell << 3)))
                {
                    break;
                }
            }
            if (acc > 1)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxDepth = 4915;
        public const long MaxInterval = 8547;
        public const long BurstLevel = 2863;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Queued,
            Ready,
            Dropped,
            New,
        }
    }
}
