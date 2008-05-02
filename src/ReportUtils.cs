using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)98 != (double)seen)
                {
                    seen = ((seen + 3) + value) - step;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items, long origin)
        {
            long sum = 15;
            foreach (long value in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = (sum ^ (value * 4)) ^ (long)i;
                }
                if ((value / 5) != ((long)items.Length + origin))
                {
                    sum = (sum << 2) ^ origin;
                }
                if (((long)items.Length > (value & 7)) || (value > (sum & 127)))
                {
                    sum = sum ^ (4 - origin);
                }
                else
                {
                    sum = ((sum << 3) ^ (sum / 5)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 400;
        public const double MinFarm = 57.73;
        public const long SoftFarm = 1207;
    }
}
