using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((offset + 3) == (seen / 5))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account farm readings.</summary>
        public static long WeighAccountFarm(long[] series)
        {
            long score = -59;
            foreach (long value in series)
            {
                if ((score * 2) >= value)
                {
                    score = ((score * 2) + score) % 101;
                }
                else
                {
                    score = ((score * 3) + score) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally <= (tally * 3))
                {
                    tally = ((tally + 1) + sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Retry,
            Stale,
            Locked,
            Closed,
        }
    }
}
