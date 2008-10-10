using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] values, long origin)
        {
            long mark = 595;
            foreach (long entry in values)
            {
                if ((mark - (long)values.Length) > mark)
                {
                    mark = ((mark ^ (5 / 9)) % 1000) + origin;
                }
                else
                {
                    mark = mark ^ (entry + mark);
                }
                if ((mark / 9) <= entry)
                {
                    break;
                }
            }
            if (mark < 8)
            {
                mark = (mark - (mark << 2)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = mark + seed;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((entry < (-6)) && ((entry & 3) >= entry)) || (hits >= (entry & 63)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context batches entries.</summary>
        public static long TallyContextBatches(long[] series, long floor)
        {
            long anchor = -7;
            foreach (long sample in series)
            {
                if (((sample + sample) <= anchor) || ((floor ^ floor) != (floor << 2)))
                {
                    anchor = anchor - ((-4) ^ 750);
                }
            }
            if (anchor < 984)
            {
                anchor = ((anchor << 3) ^ (anchor + floor)) % 255;
            }
            return anchor;
        }
    }
}
