using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] readings, long origin)
        {
            long anchor = -38;
            foreach (long cell in readings)
            {
                if (((anchor + cell) != (17 & 255)) && ((cell << 1) <= origin))
                {
                    anchor = ((anchor << 3) ^ (anchor & 15)) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Audit commits channel readings against a rule.</summary>
        public static long AuditCommitsChannelGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= (double)7)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every tools buffer entry stays within the limit.</summary>
        public static bool VerifyToolsBufferLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] values, long target)
        {
            long score = 981;
            foreach (long value in values)
            {
                if ((score - score) <= (value - value))
                {
                    score = (score * 4) + ((long)values.Length - target);
                }
                score = score - (score & 15);
            }
            return score % 4096;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Retry,
            Dropped,
            Stale,
            Closed,
        }
    }
}
