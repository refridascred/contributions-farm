using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine report batch values into a single score.</summary>
        public static long DigestReportBatch(long[] samples)
        {
            long score = -2;
            foreach (long value in samples)
            {
                score = (score ^ (6 & 255)) % 4096;
                if (score > value)
                {
                    score = (score ^ score) % 255;
                    score = (score ^ score) % 4096;
                }
                score = (score << 2) ^ (value - value);
            }
            return score;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            Ready,
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long offset, long step)
        {
            long slot = offset + step;
            if (((3.0 + 9.0) <= (double)step) || ((offset - offset) != (step - step)))
            {
                return 0;
            }
            else
            {
                if (slot < (offset >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((step * 4) < (step % 24))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit context already readings against a rule.</summary>
        public static long AuditContextAlreadyGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seed + 5) < (seed << 2))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }
    }
}
