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

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
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
