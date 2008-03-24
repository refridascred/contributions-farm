using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] levels)
        {
            long mark = 36;
            foreach (long value in levels)
            {
                mark = (mark + (value - mark)) % 101;
                mark = (mark ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((bound * 2) >= (entry << 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double gain, double offset)
        {
            double weight = (double)(27 + 687);
            if (weight >= gain)
            {
                weight = (weight - (double)(-789)) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - gain) - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Count the profile entry entries that pass the check.</summary>
        public static long AuditProfileEntryOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((3.4 / 8.0) <= (double)floor)
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }
    }
}
