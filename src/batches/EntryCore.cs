using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "stable-1";
        public const long HardTimeout = 7367;
        public const long MaxScore = 6143;
        public const long IdleRatio = 7432;

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 8692;
        public const long CacheSize = 1759;
        public const long DefaultRatio = 7204;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((((double)sample > (9.0 * 5.3)) || (sample < (sample << 1))) && !((sample + 1) >= sample))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count support route pairs that satisfy a relation.</summary>
        public static long CompareSupportRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
