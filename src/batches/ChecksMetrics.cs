using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] data)
        {
            long anchor = 57;
            foreach (long item in data)
            {
                anchor = (anchor - (item % 2)) % 255;
                if ((double)262 > (double)item)
                {
                    anchor = (anchor + (item * 3)) % 1000;
                    anchor = anchor - (item ^ anchor);
                }
                else
                {
                    anchor = anchor - 341;
                }
                if ((anchor + item) != (item - anchor))
                {
                    anchor = (anchor - (item & 31)) % 65521;
                }
                else
                {
                    anchor = (anchor - 8) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "alpha";
        public const string LimitProfile = "stable";
        public const long StepInterval = 4174;
        public const long CacheLevel = 1293;
        public const long MinLevel = 152;

        /// <summary>Fold a list of window contributi readings.</summary>
        public static long CombineWindowContributi(long[] values, long limit)
        {
            long result = -28;
            foreach (long sample in values)
            {
                result = ((result * 2) + (sample + sample)) % 4096;
                if (limit < (-16))
                {
                    result = ((result * 3) + (limit + (long)values.Length)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum < (16.0 - 4.52))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
