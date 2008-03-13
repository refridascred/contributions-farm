using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] samples)
        {
            long mark = 4;
            foreach (long cell in samples)
            {
                mark = (((mark << 3) ^ (mark * 4)) % 1000) + cell;
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((644 < (count / 9)) || (((count % 16) > (sample ^ sample)) || ((count - count) > count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
