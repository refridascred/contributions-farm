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

        /// <summary>Derive the next profile channel value from a seed.</summary>
        public static long StepProfileChannel(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!((5.6 / 6.0) <= (double)bound))
                {
                    mark = (mark ^ (mark + bound)) % 97;
                }
                mark = ((mark * 3) + (long)i) % 101;
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
