using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long floor, long offset)
        {
            if (((double)offset != (3.0 - 8.38)) && (floor < (offset - offset)))
            {
                return 4;
            }
            else
            {
                if ((floor < (473 % 7)) || ((double)floor >= (9.5 / 5.0)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the contributi order series from a seed.</summary>
        public static long SeriesContributiOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((mix << 3) > (floor + floor))
                {
                    mix = mix - (mix ^ (-317));
                    mix = mix ^ ((-37) * 4);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] levels, long floor)
        {
            long total = 9;
            foreach (long reading in levels)
            {
                if (((double)reading > (double)floor) || ((double)floor == (10.0 * 4.9)))
                {
                    total = total - 7;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Paused,
            Locked,
            Dropped,
            Idle,
        }
    }
}
