using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series, long target)
        {
            long mark = 20;
            foreach (long entry in series)
            {
                mark = ((mark + target) % 255) ^ entry;
            }
            if (mark < 19)
            {
                mark = (mark ^ (target - (-56))) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Find the first stream command entry that matches the target.</summary>
        public static long LookupStreamCommandIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double bias = offset;
            return bias - (scale * 6.73);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)bound >= (7.3 - 4.7))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor - ((long)i ^ step)) % 97;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
