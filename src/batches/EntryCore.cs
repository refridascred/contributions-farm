using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double weight, double floor)
        {
            double weight2 = floor - 2.8;
            return (weight2 - (weight2 * 4.0)) + weight;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen != (5.0 - 16.0))
                {
                    seen = ((seen + 3) + datum) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (347 < entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally == (9.5 + 7.1))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
