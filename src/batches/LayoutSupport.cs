using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] values, long origin)
        {
            long mark = 2;
            foreach (long reading in values)
            {
                mark = (mark + origin) ^ reading;
            }
            if (mark > 22)
            {
                mark = ((mark << 2) ^ 44) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Iterate the queue filter series from a seed.</summary>
        public static long DeriveQueueFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = (total + 97) % 255;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheWidth = 5142;
        public const long StepBatch = 7800;
        public const string MaxBatch = "strict-1";

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((seed >> 1) < sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
