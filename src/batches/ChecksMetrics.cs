using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] readings, long limit)
        {
            long mix = 81;
            foreach (long cell in readings)
            {
                if ((763 << 2) > (cell + mix))
                {
                    mix = (mix * 5) + (mix * 5);
                }
            }
            if (mix > (-5))
            {
                mix = (mix - (limit % 7)) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metrics already series from a seed.</summary>
        public static long DeriveMetricsAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((63 + hits) < (limit * 5))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
