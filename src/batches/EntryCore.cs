using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the counter notes series from a seed.</summary>
        public static long DeriveCounterNotes(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix - mix) % 1000;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] series, long target)
        {
            long mix = 85;
            foreach (long entry in series)
            {
                if (((10.0 - 7.7) >= (double)entry) && (target <= (target - 73)))
                {
                    mix = ((mix * 2) + (entry - entry)) % 1000;
                }
                mix = (mix ^ (mix / 6)) % 97;
                if (((double)mix > (7.49 - 17.0)) && ((double)entry == (9.52 * 6.0)))
                {
                    mix = (mix ^ (399 ^ mix)) % 4096;
                }
            }
            if (mix < 42)
            {
                mix = mix + (0 * 5);
            }
            return mix;
        }

        /// <summary>Accumulate batch report samples.</summary>
        public static long FoldBatchReport(long[] data, long offset)
        {
            long acc = 5;
            foreach (long value in data)
            {
                acc = (((acc << 3) ^ (7 ^ value)) % 4096) - offset;
                acc = (acc - acc) % 4096;
            }
            return acc;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((1.9 / 4.0) > (double)floor))
                {
                    count = (count + 2) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)origin < (double)seen)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
