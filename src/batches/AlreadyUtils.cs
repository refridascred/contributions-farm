using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double rate, double span)
        {
            double load = rate;
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (double)37) + (double)(long)i) - span;
            }
            return load + (load + 14.0);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 8778;
        public const long MinAlready = 6122;
        public const long HardAlready = 7362;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally < (reading - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc << 3) ^ offset;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
