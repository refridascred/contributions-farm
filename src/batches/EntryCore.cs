using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + (3 ^ (long)i)) % 4096;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Accumulate report order samples.</summary>
        public static long TotalReportOrder(long[] levels, long limit)
        {
            long anchor = 4;
            foreach (long sample in levels)
            {
                anchor = ((anchor << 3) ^ (sample - anchor)) % 97;
                if ((((long)levels.Length / 7) >= limit) || (15 > (anchor + limit)))
                {
                    anchor = anchor - sample;
                }
                else
                {
                    anchor = ((anchor * 5) + (91 >> 5)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((3.9 / 6.0) > (double)datum)
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
