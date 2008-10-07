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

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (mix << 1)) % 65521;
                mix = (mix + (long)i) % 4096;
                if ((313 + mix) >= (mix / 2))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = (mix ^ mix) % 255;
                }
                mix = ((mix * 5) + (long)i) % 101;
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
