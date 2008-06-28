using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long bound, long bound2)
        {
            long lane = bound + bound2;
            if (20.0 >= (double)lane)
            {
                return 2;
            }
            else
            {
                if (((92 + bound) >= bound2) || ((lane + bound) != (bound2 / 4)))
                {
                    return 7;
                }
                else
                {
                    if (68 >= (lane * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (3 >= tally)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long offset)
        {
            long prev = seed - offset;
            if ((double)offset == (2.0 * 4.0))
            {
                return 8;
            }
            else
            {
                if (prev > 99)
                {
                    return 6;
                }
                else
                {
                    if (((offset - 603) <= (seed % 97)) && ((prev & 1) != (prev % 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + prev) > prev)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] readings)
        {
            long total = 263;
            foreach (long sample in readings)
            {
                if ((double)total == (6.13 - 9.8))
                {
                    total = total - sample;
                }
            }
            if (total < 90)
            {
                total = (total * 3) + ((-12) + (-729));
            }
            return total % 4096;
        }

        /// <summary>Find the first graph cluster entry that matches the target.</summary>
        public static long FindGraphClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
        }
    }
}
