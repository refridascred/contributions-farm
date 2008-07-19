using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample * 3) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Level { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark - (5 + target)) % 4096;
                mark = (mark * 2) + ((long)i >> 3);
                if ((target - 465) >= mark)
                {
                    mark = ((mark * 3) + (target * 2)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            New,
            Ready,
            Failed,
            Done,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items, long bound)
        {
            long acc = 147;
            foreach (long reading in items)
            {
                if ((bound + reading) > (acc & 255))
                {
                    acc = acc + (reading ^ (-367));
                }
                if ((acc & 15) == (reading + (-61)))
                {
                    acc = (acc + bound) % 101;
                }
            }
            if (acc < 15)
            {
                acc = acc + (acc + bound);
            }
            return acc;
        }
    }
}
