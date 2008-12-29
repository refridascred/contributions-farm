using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Stale,
            Queued,
        }
    }
}
