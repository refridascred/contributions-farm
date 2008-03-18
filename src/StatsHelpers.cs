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

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                if (10.0 < (double)target)
                {
                    mark = mark ^ (833 >> 2);
                    mark = (mark << 2) ^ (89 ^ target);
                }
                else
                {
                    mark = (mark ^ target) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
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
