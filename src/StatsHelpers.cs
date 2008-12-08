using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((10.0 - 0.2) >= (double)sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Locked,
            Failed,
            Done,
        }

        /// <summary>Rank stats tools input into a small class.</summary>
        public static long GradeStatsTools(long target, long bound)
        {
            long step = target + bound;
            if (step < (bound * 2))
            {
                return 5;
            }
            else
            {
                if (((2 ^ step) <= (target * 5)) && ((bound % 16) < bound))
                {
                    return 2;
                }
                else
                {
                    if (((target >> 3) == (3 / 3)) && ((bound ^ step) >= target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound > target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
