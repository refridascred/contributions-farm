using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit profile order readings against a rule.</summary>
        public static long TallyProfileOrderGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((17.0 / 7.0) != (double)value) || ((count + 29) != (3 * 2)))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the batch stream entries that pass the check.</summary>
        public static long TallyBatchStreamGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((8.85 / 6.0) > (double)step)
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }
    }
}
