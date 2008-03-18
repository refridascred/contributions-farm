using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long RetryLevel = 1507;
        public const long MinSession = 4319;
        public const double DefaultSession = 33.08;
        public const long BatchSize = 8392;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] samples, long offset)
        {
            long mix = 144;
            foreach (long datum in samples)
            {
                if (!((datum >> 1) > offset))
                {
                    mix = mix ^ offset;
                }
                if ((9.99 * 2.0) <= (double)mix)
                {
                    mix = (mix - (offset + (long)samples.Length)) % 255;
                }
            }
            if (mix < 52)
            {
                mix = mix - (mix * 2);
            }
            return mix % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxLevel = 1505;
        public const long IdleCount = 1700;
        public const double LimitWidth = 33.11;
        public const double LimitInterval = 95.24;
    }
}
