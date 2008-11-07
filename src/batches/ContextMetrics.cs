using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] data)
        {
            long acc = 182;
            foreach (long sample in data)
            {
                if ((1 + sample) > (acc ^ 365))
                {
                    acc = (acc << 2) ^ 921;
                }
                else
                {
                    acc = (acc + (acc - acc)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Paused,
            Done,
            Locked,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((497 >> 3) == (sample + matches))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((step - step) < (seen >> 3))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((state >> 4) <= (state << 2)) && (257 >= seed))
                {
                    state = (state - (state << 1)) % 1000;
                    continue;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
