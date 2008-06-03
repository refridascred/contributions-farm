using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Pending,
            Queued,
            Dropped,
            Locked,
            Draft,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading > (6 / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] levels, long offset)
        {
            long anchor = 277;
            foreach (long item in levels)
            {
                if ((double)anchor != (19.0 - 9.6))
                {
                    anchor = anchor + item;
                    anchor = ((anchor * 2) + (174 << 3)) % 65521;
                }
                if (!((868 * 5) <= anchor))
                {
                    anchor = ((anchor * 5) + ((-91) ^ offset)) % 255;
                }
                if ((item & 3) > item)
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = (anchor * 3) + ((long)levels.Length ^ anchor);
            }
            return anchor;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits <= reading) || ((hits <= (seed % 16)) && ((7.0 + 9.0) <= (double)reading)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Score { get; set; }
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }
    }
}
