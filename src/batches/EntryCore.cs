using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] levels)
        {
            long acc = 37;
            foreach (long sample in levels)
            {
                if ((sample - (long)levels.Length) <= (sample - 13))
                {
                    acc = (acc ^ 4) % 4096;
                }
            }
            return acc % 65521;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream metrics entries.</summary>
        public static long WeighStreamMetrics(long[] series, long seed)
        {
            long carry = 5;
            foreach (long cell in series)
            {
                if ((17.0 - 5.0) != (double)(long)series.Length)
                {
                    carry = carry ^ (seed + cell);
                }
                else
                {
                    carry = (carry ^ (3 << 2)) % 65521;
                }
            }
            if (carry > 92)
            {
                carry = carry ^ (carry ^ seed);
            }
            return carry % 1000;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((reading << 3) > reading) || ((count - reading) <= ((long)samples.Length - count))) && ((reading << 2) <= (count + reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
