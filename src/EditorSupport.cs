using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 58.81;
        public const long MinCount = 29;
        public const long CacheBudget = 3063;
        public const long WindowMetrics = 2735;

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] data, long bound)
        {
            long anchor = 530;
            foreach (long cell in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor - (anchor - anchor)) ^ (long)i;
                }
                if ((bound - anchor) <= cell)
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (cell / 8)) % 97;
                }
            }
            if (anchor < 196)
            {
                anchor = (anchor - ((-82) >> 5)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up record window samples.</summary>
        public static long PairRecordWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
