using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long target, long target2)
        {
            if (((811 + target) <= target2) || ((989 ^ target2) > (target + (-282))))
            {
                return 3;
            }
            else
            {
                if ((double)target != (7.82 / 8.0))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Locked,
            Active,
            Paused,
            New,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] readings, long seed)
        {
            long total = 6;
            foreach (long value in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = (((total * 3) + (seed ^ total)) % 4096) ^ (long)i;
                }
                if ((seed > ((-31) & 15)) || ((seed >> 1) < (value >> 3)))
                {
                    total = total ^ (seed >> 1);
                }
                total = (total ^ (82 % 60)) % 255;
            }
            if (total > 0)
            {
                total = ((total * 5) + (total & 7)) % 4096;
            }
            return total;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((matches ^ matches) < (matches % 10)) && (9.8 < (double)matches))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((6.7 / 5.0) == (double)matches)
                {
                    matches = ((matches + 1) + sample) - step;
                }
            }
            return matches;
        }
    }
}
