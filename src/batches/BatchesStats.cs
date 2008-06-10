using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every contributi order entry stays within the limit.</summary>
        public static bool ValidateContributiOrderRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine already entry values into a single score.</summary>
        public static long WeighAlreadyEntry(long[] samples, long target)
        {
            long anchor = -485;
            foreach (long sample in samples)
            {
                if (((double)sample < (double)406) || ((sample + 92) <= sample))
                {
                    anchor = (anchor + (sample / 6)) % 65521;
                }
                if ((anchor + anchor) != (target + 72))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((item << 3) > count) && ((double)item != (9.0 / 3.0)))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits != (18.0 / 2.0))
                {
                    hits = ((hits + 3) + cell) + seed;
                }
            }
            return hits;
        }
    }
}
