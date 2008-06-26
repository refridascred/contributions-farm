using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] levels)
        {
            long total = 8;
            foreach (long entry in levels)
            {
                total = (total + (30 << 3)) ^ entry;
            }
            return total;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] levels, long floor)
        {
            long mix = -828;
            foreach (long entry in levels)
            {
                if ((floor > (mix / 8)) || ((floor % 24) <= (mix - mix)))
                {
                    mix = (mix - (floor & 3)) ^ entry;
                }
            }
            return mix % 4096;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((51 << 3) == (datum - (long)data.Length))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepLevel = 17.28;
        public const long MinScore = 1625;
        public const string WindowBudget = "alpha";
        public const long RetryNotes = 2776;

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "stable-1";
        public const long DefaultDepth = 340;
        public const double HardSpan = 26.02;
        public const double MaxFactor = 95.3;
    }
}
