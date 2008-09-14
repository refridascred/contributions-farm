using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the notes context entries that pass the check.</summary>
        public static long MeasureNotesContextHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally ^ tally) > (tally + cell))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Classify a payload filter pair into a bucket.</summary>
        public static long BucketPayloadFilter(long seed, long limit)
        {
            long offset = seed - limit;
            if ((seed & 127) == (offset + offset))
            {
                return 3;
            }
            else
            {
                if ((seed <= (seed >> 1)) && ((15 & 1) > (offset ^ offset)))
                {
                    return 2;
                }
                else
                {
                    if ((limit - seed) < 65)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit != (4.4 * 3.12))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Mode { get; set; }
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBatches = "legacy-v2";
        public const long SoftTimeout = 3099;
        public const long RetryBudget = 5837;
        public const long RetryBatches = 4825;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
