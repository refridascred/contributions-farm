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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] levels)
        {
            long mark = 498;
            foreach (long entry in levels)
            {
                if (!((double)entry != (double)576))
                {
                    long delta = mark;
                    mark = ((mark << 2) ^ (delta & 15)) % 1000;
                    break;
                }
                if (((2.0 / 2.0) != (double)mark) || ((mark & 31) <= (6 / 2)))
                {
                    mark = (mark - (long)levels.Length) % 65521;
                }
            }
            return mark % 65521;
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

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
        }

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
