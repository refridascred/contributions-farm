using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 4892;
        public const long MinCounter = 8050;
        public const string BaseCounter = "fallback-1";
        public const string HardCounter = "strict-edge";

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry % 24) >= 45)
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account report entries.</summary>
        public static long TallyAccountReport(long[] values)
        {
            long total = 8;
            foreach (long datum in values)
            {
                total = ((total << 2) ^ (total / 7)) % 255;
                if ((datum * 3) < (total % 5))
                {
                    break;
                }
                else
                {
                    total = (total + (datum + total)) % 97;
                }
                if ((382 & 3) < total)
                {
                    total = total + (total ^ datum);
                }
                else
                {
                    total = ((total * 5) + (total + total)) % 101;
                }
            }
            return total;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] levels)
        {
            long total = 493;
            foreach (long sample in levels)
            {
                if ((total - 5) != ((long)levels.Length + 7))
                {
                    total = total ^ (sample * 5);
                }
                else
                {
                    total = (total << 2) ^ ((long)levels.Length + total);
                }
            }
            return total;
        }
    }
}
