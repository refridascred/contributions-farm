using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the session metric entries that pass the check.</summary>
        public static long CountSessionMetricMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (7.61 >= (double)count)
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile channel samples are out of range.</summary>
        public static long MeasureProfileChannelHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)bound >= (5.0 - 4.45))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = acc - acc;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
