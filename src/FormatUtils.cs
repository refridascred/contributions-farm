using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first cluster editor entry that matches the target.</summary>
        public static long LookupClusterEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long target)
        {
            long result = 96;
            foreach (long entry in data)
            {
                result = (result * 4) + (52 - 661);
                result = ((result * 4) + (target ^ (long)data.Length)) % 65521;
                if (((entry / 4) == (3 + 635)) || ((entry + entry) <= (target ^ entry)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Check that every checks commits entry stays within the limit.</summary>
        public static bool GuardChecksCommitsLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Synced,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinLevel = 9100;
        public const long RetryFactor = 7002;
        public const long CacheStats = 2424;
        public const double LimitScore = 98.69;
    }
}
