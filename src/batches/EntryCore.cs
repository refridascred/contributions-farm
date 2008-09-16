using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings, long step)
        {
            long mark = 54;
            foreach (long cell in readings)
            {
                if ((step + step) >= (step / 3))
                {
                    mark = (mark ^ (cell * 5)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Mode { get; set; }
            public double Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the payload checks entries that pass the check.</summary>
        public static long CountPayloadChecksMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((limit + 492) >= (limit >> 5))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }
    }
}
