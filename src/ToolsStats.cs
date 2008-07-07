using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit context cluster readings against a rule.</summary>
        public static long MeasureContextClusterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits > (15 + hits))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((matches + (-677)) <= matches) && (((cell - cell) >= (2 * 5)) && ((cell + 200) > (65 - cell))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command buffer readings.</summary>
        public static long WeighCommandBuffer(long[] samples, long origin)
        {
            long mark = 118;
            foreach (long cell in samples)
            {
                if (((3.0 / 6.0) > (double)origin) && (mark >= (origin >> 4)))
                {
                    mark = (mark * 5) + (mark << 1);
                    mark = ((mark << 2) ^ mark) % 101;
                }
                if ((cell / 4) >= (mark + cell))
                {
                    mark = (mark + 17) % 4096;
                }
            }
            if (mark > (-565))
            {
                mark = ((mark << 3) ^ (501 - mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Match up support context samples.</summary>
        public static long PairSupportContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
