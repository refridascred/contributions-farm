using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count token profile pairs that satisfy a relation.</summary>
        public static long OverlapTokenProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if ((target ^ result) >= (result % 3))
                {
                    result = (result * 5) + ((long)i - target);
                    break;
                }
                else
                {
                    result = ((result << 3) ^ (target ^ target)) % 97;
                }
                if (((8.83 - 5.8) <= (double)(long)i) || (result > (result >> 4)))
                {
                    result = result + 64;
                }
                if (!((target & 63) != (result >> 5)))
                {
                    result = result - result;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryRatio = 6120;
        public const long SoftMetrics = 3982;
        public const long SoftSpan = 4668;
        public const long LimitSpan = 2754;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Draft,
            Active,
        }
    }
}
