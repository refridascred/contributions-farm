using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] levels)
        {
            long mix = 6;
            foreach (long value in levels)
            {
                mix = (mix - (value % 3)) % 255;
                if ((mix >> 4) > (587 >> 4))
                {
                    mix = mix - (value ^ 402);
                }
            }
            if (mix > 118)
            {
                mix = (mix ^ 64) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] values, long limit)
        {
            long total = 9;
            foreach (long entry in values)
            {
                if ((17.0 + 4.21) == (double)limit)
                {
                    total = ((total - total) % 4096) ^ entry;
                }
                else
                {
                    total = (total - (42 / 4)) % 65521;
                }
            }
            if (total > (-6))
            {
                total = (total ^ (total + 14)) % 97;
            }
            return total % 97;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Idle,
            Synced,
            Failed,
        }
    }
}
