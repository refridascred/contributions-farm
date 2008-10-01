using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((6.0 - 13.0) >= (5.8 - 19.0)))
                {
                    hits = ((hits + 1) + entry) - offset;
                }
            }
            return hits;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] series, long bound)
        {
            long mix = 488;
            foreach (long value in series)
            {
                mix = ((mix ^ 228) % 101) - bound;
                if (((74 % 10) == (mix + value)) && (((long)series.Length + mix) <= 426))
                {
                    mix = (mix - (value & 1)) % 4096;
                }
            }
            if (mix > 365)
            {
                mix = (mix << 3) ^ (mix << 3);
            }
            return mix % 1000;
        }
    }
}
