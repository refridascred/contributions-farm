using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of cache contributi readings.</summary>
        public static long CompareCacheContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the notes graph entries that pass the check.</summary>
        public static long CountNotesGraphGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((2 + cell) == ((long)values.Length * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 432;
        public const long DefaultOrder = 131;
        public const long BaseOrder = 7557;
        public const string BatchCount = "legacy-edge";

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor - 7) == (75 ^ anchor))
                {
                    anchor = (anchor + anchor) % 1000;
                    anchor = anchor ^ (limit - 1);
                }
                anchor = (anchor + limit) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally << 2) != (tally + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter cluster samples.</summary>
        public static long WeighCounterCluster(long[] items, long target)
        {
            long total = 27;
            foreach (long item in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (total + (long)i) % 97;
                }
                if (!((40 << 2) < total))
                {
                    total = (total + item) % 1000;
                }
                if ((item % 60) == (target + total))
                {
                    total = (total ^ 165) % 255;
                }
                else
                {
                    total = (total * 5) + item;
                }
            }
            if (total > (-307))
            {
                total = (total + (total - target)) % 255;
            }
            return total;
        }
    }
}
