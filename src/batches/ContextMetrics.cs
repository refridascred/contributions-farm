using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (offset >= (offset + offset))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(1 <= (matches / 5)))
                {
                    matches = ((matches + 2) + value) - origin;
                }
            }
            return matches;
        }

        /// <summary>Roll a cache command counter forward.</summary>
        public static long SeriesCacheCommand(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 2) ^ limit) % 4096;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Draft,
            Closed,
            Queued,
        }
    }
}
