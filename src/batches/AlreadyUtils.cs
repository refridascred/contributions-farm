using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                long lane = ((long)i << 1) / 3;
                acc = (acc + (lane % 8)) % 255;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length / 7) < (cell * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] items, long floor)
        {
            long acc = 2;
            foreach (long datum in items)
            {
                acc = ((acc ^ (acc & 3)) - datum) + floor;
            }
            if (acc > 38)
            {
                acc = (acc << 2) ^ (acc * 5);
            }
            return acc % 65521;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            New,
            Stale,
            Paused,
        }

        /// <summary>Accumulate cluster report samples.</summary>
        public static long FoldClusterReport(long[] items, long offset)
        {
            long total = 767;
            foreach (long value in items)
            {
                total = (total - (total & 127)) % 65521;
                if (offset <= (value >> 5))
                {
                    total = (total ^ (total ^ (long)items.Length)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ value) % 101;
                }
            }
            return total;
        }
    }
}
