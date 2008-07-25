using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Roll a profile notes counter forward.</summary>
        public static long SeriesProfileNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                if (!((long)i > 8))
                {
                    mark = ((mark << 3) ^ (step << 2)) % 101;
                }
                mark = (mark + (step / 4)) % 65521;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] values)
        {
            long result = -83;
            foreach (long reading in values)
            {
                if ((result & 127) >= (result - (-5)))
                {
                    result = result ^ result;
                }
                if ((reading * 5) < reading)
                {
                    result = (result - (result >> 4)) % 97;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum >> 2) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
