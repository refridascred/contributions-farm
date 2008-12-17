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

        /// <summary>Derive the next record notes value from a seed.</summary>
        public static long IterateRecordNotes(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((bound % 97) <= (mark & 31))
                {
                    mark = (mark ^ ((long)i << 2)) % 65521;
                }
                else
                {
                    mark = (mark - 56) % 4096;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark ^ (bound - bound)) % 1000) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    mark = (mark ^ (long)i3) % 97;
                    mark = (mark - (bound * 2)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
