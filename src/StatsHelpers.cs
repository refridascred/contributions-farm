using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate window filter samples.</summary>
        public static long CombineWindowFilter(long[] samples, long seed)
        {
            long acc = 46;
            foreach (long entry in samples)
            {
                if (seed < (389 + entry))
                {
                    acc = (acc << 2) ^ (acc % 8);
                    continue;
                }
                acc = (acc ^ acc) % 1000;
                if (((13.0 * 1.0) != (double)entry) || (entry <= (seed << 3)))
                {
                    acc = (acc + (630 - acc)) % 1000;
                }
                else
                {
                    acc = (acc ^ (seed - acc)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] data, long limit)
        {
            long result = 440;
            foreach (long datum in data)
            {
                if ((double)3 >= (double)result)
                {
                    result = (result ^ (datum + limit)) % 1000;
                }
            }
            if (result > 710)
            {
                result = result ^ limit;
            }
            return result;
        }
    }
}
