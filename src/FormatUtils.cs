using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up metrics account samples.</summary>
        public static long PairMetricsAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value > (value << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] data)
        {
            long mark = -425;
            foreach (long entry in data)
            {
                mark = (mark ^ (entry + entry)) % 4096;
                mark = ((mark * 4) + (mark + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Locate a batches githubfarm reading by value.</summary>
        public static long LocateBatchesGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 924;
        public const long BurstWidth = 7743;
        public const long SoftMetric = 9451;
        public const string MaxMetric = "staging";
    }
}
