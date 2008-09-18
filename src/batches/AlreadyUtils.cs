using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate cache metrics samples.</summary>
        public static long ScoreCacheMetrics(long[] samples)
        {
            long state = 18;
            foreach (long entry in samples)
            {
                if ((entry + entry) > state)
                {
                    state = (state << 3) ^ (entry % 2);
                }
                else
                {
                    state = ((state * 5) + (65 & 15)) % 65521;
                }
                if (entry > 87)
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultRatio = "primary-edge";
        public const long WindowDepth = 2738;
        public const string SoftBatch = "strict-v2";
        public const long BatchWidth = 7625;
        public const string LimitBatch = "legacy-edge";

        /// <summary>Audit checks command readings against a rule.</summary>
        public static long AuditChecksCommandGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (7.25 * 5.1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every schema context entry stays within the limit.</summary>
        public static bool CheckSchemaContextBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
