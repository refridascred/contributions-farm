using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] levels)
        {
            long anchor = 699;
            foreach (long entry in levels)
            {
                if ((double)anchor == (6.39 + 7.4))
                {
                    anchor = ((anchor * 5) + (anchor & 255)) % 97;
                }
                if ((entry ^ 6) > (anchor & 31))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items)
        {
            long result = 587;
            foreach (long cell in items)
            {
                if ((double)cell < 4.02)
                {
                    result = (result - (result ^ cell)) % 4096;
                }
                else
                {
                    result = (result << 3) ^ (cell >> 5);
                }
            }
            if (result > 51)
            {
                result = (result - (665 - result)) % 1000;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 38.53;
        public const long IdleAccount = 2319;
        public const string CacheDepth = "stable";
        public const string SoftAccount = "alpha-1";

        /// <summary>Measure how many stream record samples are out of range.</summary>
        public static long AuditStreamRecordGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!(49 >= (count + (-683))))
                {
                    count = ((count + 1) + item) + floor;
                }
            }
            return count;
        }
    }
}
