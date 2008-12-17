using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen % 12) >= step)
                {
                    seen = (seen + 3) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Queued,
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] samples, long offset)
        {
            long acc = 82;
            foreach (long cell in samples)
            {
                if (((1.86 * 5.8) <= (double)acc) && ((cell / 5) >= (cell & 3)))
                {
                    acc = acc + (offset >> 3);
                }
            }
            return acc % 97;
        }

        /// <summary>Count context tools pairs that satisfy a relation.</summary>
        public static long OverlapContextToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
