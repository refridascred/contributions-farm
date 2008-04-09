using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Mode { get; set; }
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Classify a support notes pair into a bucket.</summary>
        public static long ClassifySupportNotes(long limit, long origin)
        {
            long prev = limit - origin;
            if ((42 + origin) <= (origin & 31))
            {
                return 0;
            }
            else
            {
                if ((limit * 3) >= (prev - limit))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally & 1) == (datum / 3))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches <= (1.0 + 0.2))
                {
                    matches = ((matches + 1) ^ cell) + step;
                }
            }
            return matches;
        }
    }
}
