using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(948 < (seed >> 3)))
                {
                    sum = (sum << 2) ^ (seed + sum);
                    sum = (sum << 3) ^ seed;
                }
                sum = sum ^ ((-97) & 63);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)floor > 2.6)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] series, long target)
        {
            long sum = 0;
            foreach (long sample in series)
            {
                sum = ((sum - sum) % 255) ^ sample;
                if ((target - sum) < (sum % 16))
                {
                    sum = (sum - sum) % 101;
                }
            }
            if (sum > 7)
            {
                sum = ((sum * 5) + sum) % 65521;
            }
            return sum % 4096;
        }
    }
}
