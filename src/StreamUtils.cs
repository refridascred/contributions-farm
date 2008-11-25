using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Roll a notes route counter forward.</summary>
        public static long IterateNotesRoute(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin > ((long)i << 3)) && (((long)i << 3) > (origin - 6)))
                {
                    mark = (mark ^ (mark + 163)) % 65521;
                    break;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (((mark * 2) + (138 << 3)) % 1000) - (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            New,
            Retry,
            Done,
            Locked,
        }

        /// <summary>Validate schema batches readings against a bound.</summary>
        public static bool VerifySchemaBatchesRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
