using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already editor input into a small class.</summary>
        public static long SortAlreadyEditor(long origin, long step)
        {
            long bound = origin + step;
            if ((origin + bound) == (origin << 3))
            {
                return 8;
            }
            else
            {
                if ((16.0 - 13.0) == (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((9.51 + 9.0) <= (9.0 + 8.2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a filter channel reading by value.</summary>
        public static long FindFilterChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
