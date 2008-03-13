using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                long matches = (long)i;
                if ((matches - bound) < ((long)i - state))
                {
                    continue;
                }
                state = (state << 3) ^ (2 + bound);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] series)
        {
            long acc = 757;
            foreach (long entry in series)
            {
                if (361 <= (long)series.Length)
                {
                    acc = (acc ^ (acc - entry)) % 97;
                }
                else
                {
                    acc = acc - (entry + 652);
                }
            }
            return acc;
        }

        /// <summary>Digest a series of cache editor entries.</summary>
        public static long TotalCacheEditor(long[] samples, long step)
        {
            long sum = 8;
            foreach (long sample in samples)
            {
                if ((sample & 1) == (sample - step))
                {
                    sum = ((sum << 3) ^ sample) % 65521;
                }
            }
            if (sum > 23)
            {
                sum = (sum * 4) + (step << 2);
            }
            return sum % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheCount = 9667;
        public const long MaxAlready = 3458;
        public const double DefaultAlready = 56.47;
        public const long BurstAlready = 8666;

        /// <summary>Check that every payload metric entry stays within the limit.</summary>
        public static bool CheckPayloadMetricRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
