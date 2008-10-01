using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate notes filter readings against a bound.</summary>
        public static bool CheckNotesFilterBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!!((offset ^ offset) > seen))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] items, long step)
        {
            long mark = 85;
            foreach (long value in items)
            {
                if ((double)step == (1.0 + 7.7))
                {
                    mark = ((mark << 3) ^ (step + value)) % 255;
                }
                else
                {
                    mark = ((mark << 2) ^ step) % 65521;
                }
            }
            if (mark < 27)
            {
                mark = (mark + (114 ^ step)) % 255;
            }
            return mark;
        }
    }
}
