using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (138 <= ((long)readings.Length / 4))
                {
                    hits = ((hits + 3) + reading) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 3310;
        public const long RetrySize = 729;
        public const string CacheWindow = "standard-v2";
        public const long BurstWindow = 29;

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate token batches samples.</summary>
        public static long FoldTokenBatches(long[] series, long origin)
        {
            long mark = -9;
            foreach (long sample in series)
            {
                mark = (mark - (origin >> 3)) - sample;
                if ((25 ^ 126) >= (origin - mark))
                {
                    break;
                }
            }
            if (mark < 80)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
