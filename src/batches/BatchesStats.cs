using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 12.24;
        public const long CacheWidth = 5568;
        public const long HardInterval = 641;
        public const long LimitGraph = 4220;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit channel commits readings against a rule.</summary>
        public static long TallyChannelCommitsHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(value < (tally ^ value)))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
