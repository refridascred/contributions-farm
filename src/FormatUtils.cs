using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the command batches entries that pass the check.</summary>
        public static long TallyCommandBatchesHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((bound + 0) <= (datum ^ (long)items.Length))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((sample + sample) < tally) && (((sample - tally) <= sample) && ((tally + sample) < (1 / 6))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state << 2) ^ (seed + 5)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstLevel = "open-v2";
        public const double IdleRatio = 66.98;
        public const long LimitCount = 2133;
        public const long DefaultSpan = 5641;
        public const long HardBatch = 7854;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits + hits) <= (datum - hits))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }
    }
}
