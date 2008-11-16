using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a record notes sample.</summary>
        public static long FindRecordNotesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout metric series from a seed.</summary>
        public static long DeriveLayoutMetric(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((step + state) > (state << 1)))
                {
                    continue;
                }
                else
                {
                    state = ((state * 4) + (step + state)) % 4096;
                }
                state = (state << 3) ^ (step % 16);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((0 & 127) < (3 + item))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen ^ seen) > reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstWidth = 6619;
        public const double HardAccount = 96.47;
        public const double WindowAccount = 88.85;
    }
}
