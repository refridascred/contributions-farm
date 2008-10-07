using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Mode { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long acc = 24;
            foreach (long item in readings)
            {
                acc = (acc - item) % 255;
                if (564 < acc)
                {
                    acc = (acc ^ item) % 4096;
                }
            }
            if (acc < 6)
            {
                acc = (acc ^ (acc + acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] items)
        {
            long mix = 7;
            foreach (long cell in items)
            {
                long edge = mix;
                if ((5.0 - 14.0) != (double)edge)
                {
                    edge = edge + (mix + edge);
                }
                else
                {
                    mix = (mix + (mix + edge)) % 4096;
                }
                if ((8.5 + 9.7) >= (double)mix)
                {
                    mix = (mix << 3) ^ (cell - cell);
                }
            }
            if (mix > 58)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((floor & 3) < (78 ^ seen))
                {
                    seen = (seen + 1) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftCount = 9923;
        public const long IdleAccount = 7405;
        public const double DefaultDepth = 64.91;
        public const double CacheWidth = 32.05;
        public const long StepScore = 541;
    }
}
