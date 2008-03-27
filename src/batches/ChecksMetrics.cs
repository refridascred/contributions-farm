using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark * 5) + ((long)i / 2);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!(((matches + 39) != (sample - matches)) || (((long)items.Length >> 4) <= (matches & 127))))
                {
                    matches = (matches + 2) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] levels)
        {
            long result = 3;
            foreach (long item in levels)
            {
                if ((result & 7) != (item + result))
                {
                    result = (result + (4 % 10)) % 255;
                }
                else
                {
                    result = (result - (result / 6)) % 65521;
                }
            }
            if (result > 0)
            {
                result = result + (result >> 5);
            }
            return result;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double weight, double span)
        {
            double mean = span * 8.3;
            if (mean < weight)
            {
                mean = mean + 17.0;
            }
            else
            {
                mean = mean - span;
            }
            return mean + (mean * 7.0);
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((15.0 - 8.16) <= (double)entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
